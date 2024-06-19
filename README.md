# What I want to do
I'm trying to extend a type from another subgraph.

In this case, I have two subgraphs:
- `ParentSubgraph` [parent.graphql](graphql/parent.graphql)
  - One type: `parent`
- `ChildSubgraph` [child.graphql](graphql/child.graphql)
  - One type: `child`
  - One type extension: `parent`

# What is happening

I'm able to compose the two subgraphs into a supergraph. However, when I attempt to execute the following query:

```graphql
query Query {
  allParents {
    id
    name
    children {
      id
      name
    }
  }
}
```

I receive the following error:

```json
{
  "data": null,
  "errors": [
    {
      "message": "HTTP fetch failed from 'children': 500: Internal Server Error",
      "extensions": {
        "code": "SUBREQUEST_HTTP_ERROR",
        "service": "children",
        "reason": "500: Internal Server Error",
        "http": {
          "status": 500
        }
      }
    },
    {
      "message": "Unexpected Execution Error",
      "path": [
        "allParents",
        "@"
      ],
      "extensions": {
        "message": "For more details look at the `Errors` property.\r\n\r\n1. The apollo gateway tries to resolve an entity for which no EntityResolver method was found.\r\n",
        "stackTrace": "   at ApolloGraphQL.HotChocolate.Federation.Helpers.EntitiesResolver.ResolveAsync(ISchema schema, IReadOnlyList`1 representations, IResolverContext context)\r\n   at HotChocolate.Types.ResolveObjectFieldDescriptorExtensions.<>c__DisplayClass3_0`1.<<Resolve>b__0>d.MoveNext()\r\n--- End of stack trace from previous location ---\r\n   at HotChocolate.Types.Helpers.FieldMiddlewareCompiler.<>c__DisplayClass9_0.<<CreateResolverMiddleware>b__0>d.MoveNext()\r\n--- End of stack trace from previous location ---\r\n   at HotChocolate.Execution.Processing.Tasks.ResolverTask.ExecuteResolverPipelineAsync(CancellationToken cancellationToken)\r\n   at HotChocolate.Execution.Processing.Tasks.ResolverTask.TryExecuteAsync(CancellationToken cancellationToken)"
      }
    }
  ],
  "extensions": {
    "valueCompletion": [
      {
        "message": "Cannot return null for non-nullable field Parent.children",
        "path": [
          "allParents",
          0
        ]
      },
      {
        "message": "Cannot return null for non-nullable array element of type Parent at index 0",
        "path": [
          "allParents",
          0
        ]
      },
      {
        "message": "Cannot return null for non-nullable field [Parent!]!.allParents",
        "path": [
          "allParents"
        ]
      }
    ]
  }
}
```

# Question

How do I get the `parent`.`children` property to resolve to the code declared in `ChildSubgraph`?

# Steps to reproduce

Run the two graphql subgraphs by either:
- Run the solution from Visual Studio.
- Run each graph with `dotnet run` in separate terminals.

And
- Start rover with [these instructions](apollo/README.md).

Attach to the supergraph using [Apollo Studio](https://studio.apollographql.com/sandbox/explorer) and execute the above query.