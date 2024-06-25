using ApolloGraphQL.HotChocolate.Federation;

namespace ChildSubgraph.Types
{
    [Key("id")]
    public class Child
    {
        public Child(string id, string parentId, string name)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
        }

        [ID]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Name { get; set; }
    }
}
