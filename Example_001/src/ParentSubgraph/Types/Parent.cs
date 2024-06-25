using ApolloGraphQL.HotChocolate.Federation;
using ParentSubgraph.Data;

namespace ApolloFederationRepro.Types
{
    [Key("id")]
    public class Parent
    {
        public Parent(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [ID]
        public string Id { get; }

        public string Name { get; }

        [ReferenceResolver]
        public static Parent? Get(ParentRepository repository, string id)
        {
            return repository.GetParent(id);
        }
    }
}
