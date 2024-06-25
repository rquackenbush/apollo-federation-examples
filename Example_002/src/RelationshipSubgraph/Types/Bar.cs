using ApolloGraphQL.HotChocolate.Federation;

namespace RelationshipSubgraph.Types
{
    [Key("id")]
    public class Bar
    {
        public Bar(string id)
        {
            Id = id;
        }

        [ID]
        public string Id { get; }

        [ReferenceResolver]
        public static Bar Get(string id)
        {
            return new Bar(id);
        }
    }
}
