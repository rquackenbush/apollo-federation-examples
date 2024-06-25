using BarSubgraph.Data;

namespace BarSubgraph.Types
{
    public class Query
    {
        public IEnumerable<Bar> GetAllBar(BarRepository repository)
        {
            return repository.GetAllBars();
        }
    }
}
