using ApolloGraphQL.HotChocolate.Federation;
using BarSubgraph.Data;
using Common;

namespace BarSubgraph.Types
{
    [Key("id")]
    public class Bar : IEntity
    {
        public Bar(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [ID]
        public string Id { get; set; }

        public string Name { get; set; }

        [ReferenceResolver]
        public static Bar? Get(BarRepository repository, string id)
        {
            return repository.GetBar(id);
        }
    }
}
