## Example 1
Extend a type from another subgraph.

- `ParentSubgraph`
  - type: `parent`
- `ChildSubgraph`
  - type: `child`
  - type: `parent`
    - this type adds a property (resolver) `children` that enumerates the children of a parent.