using ApolloFederationRepro.Types;

namespace ParentSubgraph.Data
{
    public class ParentRepository
    {
        private readonly List<Parent> parents = new List<Parent>
        {
            new Parent("1", "Parent 1"),
            new Parent("2", "Parent 2"),
            new Parent("3", "Parent 3"),
            new Parent("4", "Parent 4"),
        };

        public IEnumerable<Parent> GetAllParents()
        {
            return parents;
        }

        public Parent? GetParent(string id)
        {
            return parents.FirstOrDefault(p => p.Id == id);
        }
    }
}
