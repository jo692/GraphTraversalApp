# GraphTraversalApp
Simple app to visualise various graph search and traversal algorithms.

Work in progress.
Currently the app can generate pseudo-random graphs of between 7-10 nodes and the user can select a node as the start node of the algorithms. Currently the DFS and BFS algorithm are implemented to take edge weight into account, meaning that closer nodes will be visited first rather than the random selection usually taken by these algorithms on unweighted graphs.

To be implemented:
- Reset graph button which will allow the user to keep the current graph configuration but reset it so that another algorithm can be performed on it.

Possible future improvements/additions: 
- Edge weight checkbox, allowing the algorithm to be executed on both a weighted and non-weighted graph.
- Dijkstra's algorithm button for an optimal route visualisation.
- Allow the user to create custom graphs by placing their own nodes and edges.
- Possibly highlight the edges taken not just the nodes.
