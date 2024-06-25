using ApolloGraphQL.HotChocolate.Federation;
using ChildSubgraph.Data;

namespace ChildSubgraph.Types;

[Key("id")]
public class Parent
{
    public Parent(string id)
    {
        Id = id;
    }

    [ID]
    public string Id { get; }

    public IEnumerable<Child> Children([Parent] Parent parent, ChildRepository repository)
    {
        return repository.GetChildren(parent.Id);
    }

    [ReferenceResolver]
    public static Parent Get(string id)
    {
        return new Parent(id);
    }
}
