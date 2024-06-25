using Common;
using RelationshipSubgraph.Data;

namespace RelationshipSubgraph.Types
{
    public class Mutation
    {
        public Payload CreateRelationship(RelationshipRepository repository, string id, string name, string sourceId, string targetId)
        {
            try
            {
                repository.CreateRelationship(id, name, sourceId, targetId);

                return new Payload(true, "Relationship created.");
            }
            catch(Exception ex)
            {
                return new Payload(false, ex.Message);
            }
        }

        public Payload DeleteRelationship(RelationshipRepository repository, string id)
        {
            try
            {
                repository.DeleteRelationship(id);

                return new Payload(true, "Relationship deleted.");
            }
            catch(Exception ex)
            {
                return new Payload(false, ex.Message);
            }
        }
    }
}
