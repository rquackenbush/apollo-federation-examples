using BarSubgraph.Types;

namespace BarSubgraph.Data
{
    public class BarRepository
    {
        private readonly List<Bar> bars = new List<Bar>
        {
            new Bar("bar.1", "Bar 1"),
            new Bar("bar.2", "Bar 2"),
            new Bar("bar.3", "Bar 3"),
            new Bar("bar.4", "Bar 4")
        };

        public IEnumerable<Bar> GetAllBars()
        {
            return bars;
        }

        public Bar? GetBar(string id)
        {
            return bars
                .FirstOrDefault(b => b.Id == id);
        }
    }
}
