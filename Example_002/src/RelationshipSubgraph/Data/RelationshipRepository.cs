using RelationshipSubgraph.Types;

namespace RelationshipSubgraph.Data
{
    public class RelationshipRepository
    {
        private readonly List<Relationship> relationships = new List<Relationship>
        {
            new Relationship("relationship.1", "hasBar", "foo.1", "bar.1")
        };

        public IEnumerable<Relationship> GetAllRelationships()
        {
            return relationships;
        }

        public Relationship? GetRelationship(string id)
        {
            return relationships
                .FirstOrDefault(r => r.Id == id);
        }

        public void CreateRelationship(string id, string name, string sourceId, string targetId)
        {
            if (GetRelationship(id) != null)
                throw new InvalidOperationException($"A relationship with id '{id}' already exists.");

            if (relationships.Any(r => r.Name == name && r.SourceId == sourceId && r.TargetId == targetId))
                throw new InvalidOperationException($"A relationship of name '{name}' already exists from entity '{sourceId}' to target '{targetId}'.");

            var relationship = new Relationship(id, name, sourceId, targetId);

            relationships.Add(relationship);
        }

        public void DeleteRelationship(string id)
        {
            var relationship = GetRelationship(id);

            if (relationship == null)
                throw new InvalidOperationException($"Unable to find relationship with id '{id}'.");

            relationships.Remove(relationship);
        }
    }
}
