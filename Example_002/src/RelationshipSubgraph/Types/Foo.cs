using ApolloGraphQL.HotChocolate.Federation;
using RelationshipSubgraph.Data;

namespace RelationshipSubgraph.Types
{
    [Key("id")]
    public class Foo
    {
        public Foo(string id)
        {
            Id = id;
        }

        [ID]
        public string Id { get; }

        public IEnumerable<Bar> Bars([Parent] Foo parent, RelationshipRepository repository)
        {
            return repository.GetAllRelationships()
                .Where(r => r.SourceId == parent.Id)
                .Select(r => new Bar(r.TargetId));
        }


        [ReferenceResolver]
        public static Foo Get(string id)
        {
            return new Foo(id);
        }
    }
}
