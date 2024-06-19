using ApolloGraphQL.HotChocolate.Federation;

namespace ChildSubgraph.Types
{
    [Key("id")]
    public class Child
    {
        public Child(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [ID]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
