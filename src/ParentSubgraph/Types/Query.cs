namespace ApolloFederationRepro.Types
{
    public class Query
    {
        public List<Parent> AllParents()
        {
            return new List<Parent>
            {
                new Parent("1", "Parent 1"),
                new Parent("2", "Parent 2"),
                new Parent("3", "Parent 3")
            };
        }
    }
}
