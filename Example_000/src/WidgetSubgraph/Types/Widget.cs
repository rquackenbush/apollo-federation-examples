using ApolloGraphQL.HotChocolate.Federation;
using WidgetSubgraph.Data;

namespace WidgetSubgraph.Types
{
    [Key("id")]
    public class Widget
    {
        public Widget(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [ID]
        public string Id { get; }

        public string Name { get; set; }

        [ReferenceResolver]
        public static Widget? Get(WidgetRepository repository, string id)
        {
            return repository.GetWidget(id);
        }
    }
}
