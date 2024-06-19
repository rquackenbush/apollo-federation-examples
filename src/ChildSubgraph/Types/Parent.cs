using ApolloGraphQL.HotChocolate.Federation;

namespace ChildSubgraph.Types
{
    [Key("id")]
    [Extends]
    public class Parent
    {
        [ID]
        public string Id { get; set; }

        public List<Child> Children()
        {
            return new List<Child>
            {
                new Child("1", "Child 1"),
                new Child("2", "Child 2")
            };
        }

    }
}
