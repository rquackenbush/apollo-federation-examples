using FooSubgraph.Types;

namespace FooSubgraph.Data
{
    public class FooRepository
    {
        private readonly List<Foo> foos = new List<Foo>
        {
            new Foo("foo.1", "Foo 1"),
            new Foo("foo.2", "Foo 2"),
            new Foo("foo.3", "Foo 3"),
            new Foo("foo.4", "Foo 4"),
        };

        public IEnumerable<Foo> GetAllFoos()
        {
            return foos;
        }

        public Foo? GetFoo(string id)
        {
            return foos
                .FirstOrDefault(f => f.Id == id);    
        }
    }
}
