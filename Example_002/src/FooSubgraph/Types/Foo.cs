using ApolloGraphQL.HotChocolate.Federation;
using Common;
using FooSubgraph.Data;

namespace FooSubgraph.Types
{
    [Key("id")]
    public class Foo //: IEntity
    {
        public Foo(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [ID]
        public string Id { get; set; }

        public string Name { get; set; }

        [ReferenceResolver]
        public static Foo? Get(FooRepository repository, string id)
        {
            return repository.GetFoo(id);
        }
    }
}
