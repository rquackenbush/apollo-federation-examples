using ApolloGraphQL.HotChocolate.Federation;

namespace ChildSubgraph.Types
{
    [Key("id")]
    public class Parent
    {
        [ID]
        public string Id { get; set; }

        public List<Child> Children([Parent] Parent parent)
        {
            return new List<Child>
            {
                new Child($"{parent.Id}.1", $"Child {parent.Id}.1"),
                new Child($"{parent.Id}.2", $"Child {parent.Id}.2")
            };
        }

        [ReferenceResolver]
        public static Parent Get(string id)
        {
            return new Parent
            {
                Id = id
            };
        }

    }
}
