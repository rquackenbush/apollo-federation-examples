using ChildSubgraph.Types;

namespace ChildSubgraph.Data
{
    public class ChildRepository
    {
        private readonly List<Child> children = new List<Child>
        {
            new Child("1.1", "1", "Child 1.1"),
            new Child("1.2", "1", "Child 1.2"),

            new Child("2.1", "2", "Child 2.1"),
            new Child("2.2", "2", "Child 2.2"),
        };

        public IEnumerable<Child> GetAllChildren()
        {
            return children;
        }

        public IEnumerable<Child> GetChildren(string parentId)
        {
            return children
                .Where(c => c.ParentId == parentId);
        }
    }
}
