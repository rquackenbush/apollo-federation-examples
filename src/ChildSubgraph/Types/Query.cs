namespace ChildSubgraph.Types
{
    public class Query
    {
        public List<Child> AllChildren()
        {
            return new List<Child>()
            {
                new Child("1", "Child 1"),
                new Child("2", "Child 2"),
            };
        }
    }
}
