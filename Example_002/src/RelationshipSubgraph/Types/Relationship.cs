using ApolloGraphQL.HotChocolate.Federation;
using RelationshipSubgraph.Data;

namespace RelationshipSubgraph.Types
{
    [Key("id")]
    public class Relationship
    {
        public Relationship(string id, string name, string sourceId, string targetId)
        {
            Id = id;
            Name = name;
            SourceId = sourceId;
            TargetId = targetId;
        }

        [ID]
        public string Id { get; set; }

        public string Name { get; set; }

        public string SourceId { get; set; }

        public string TargetId { get; set; }

        [ReferenceResolver]
        public static Relationship? Get(RelationshipRepository repository, string id)
        {
            return repository.GetRelationship(id);
        }
    }
}
