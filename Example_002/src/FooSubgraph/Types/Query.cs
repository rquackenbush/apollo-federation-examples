using FooSubgraph.Data;

namespace FooSubgraph.Types
{
    public class Query
    {
        public IEnumerable<Foo> GetAllFoo(FooRepository repository)
        {
            return repository.GetAllFoos();
        }
    }
}
