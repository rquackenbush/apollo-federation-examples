using ApolloGraphQL.HotChocolate.Federation;

namespace ApolloFederationRepro.Types
{
    [Key("id")]
    [GraphQLDescription("A thing.")]
    public class Widget
    {
        public Widget(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [GraphQLDescription("Id of the widget")]
        [ID]
        public string Id { get; set; }

        public string Name { get; set; }

        [ReferenceResolver]
        public static Widget Get(string id)
        {
            return new Widget("42", "Widget from Get");
        }
    }
}
