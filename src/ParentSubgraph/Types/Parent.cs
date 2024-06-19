using ApolloGraphQL.HotChocolate.Federation;

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
        public string Id { get; set; }

        public string Name { get; set; }

        [ReferenceResolver]
        public static Parent Get(string id)
        {
            return new Parent("42", "Parent from Get");
        }
    }
}
