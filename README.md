# Apollo / HotChocolate Type Extension Demo
I'm trying to extend a type from another subgraph.

In this case, I have two subgraphs:
- `ParentSubgraph` [parent.graphql](graphql/parent.graphql)
  - type: `parent`
- `ChildSubgraph` [child.graphql](graphql/child.graphql)
  - type: `child`
  - type: `parent`
    - this type adds a property (resolver) `children` that enumerates the children of a parent.

