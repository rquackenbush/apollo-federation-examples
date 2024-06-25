using ChildSubgraph.Data;

namespace ChildSubgraph.Types
{
    public class Query
    {
        public IEnumerable<Child> AllChildren(ChildRepository repository)
        {
            return repository.GetAllChildren();
        }
    }
}
