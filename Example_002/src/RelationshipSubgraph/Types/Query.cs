using RelationshipSubgraph.Data;

namespace RelationshipSubgraph.Types
{
    public class Query
    {
        public IEnumerable<Relationship> AllRelationships(RelationshipRepository repository)
        {
            return repository.GetAllRelationships();
        }
    }
}
