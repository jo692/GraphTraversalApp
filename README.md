# GraphTraversalApp
Simple app to visualise various graph search and traversal algorithms.

Work in progress.
Currently the app can generate pseudo-random graphs of between 7-10 nodes and the user can select a node as the start node of the algorithms. Currently the DFS and BFS algorithm are implemented to take edge weight into account, meaning that closer nodes will be visited first rather than the random selection usually taken by these algorithms on unweighted graphs. 
Graphs can now be reused through the reset button, allowing the user to select a new start node/algorithm.

[30/10/19] Dijkstra's algorithm button now implemented, though still in early stages.
To perform this algorithm:
1. Generate graph and select start node as with any other algorithm.
2. Press 'Dijkstra' button, then when prompted select a destination node.
3. Press the button again to begin.

Known bugs:
- (Dijkstra) Distanced painted above nodes do not clear after pressing the reset button.
- (Dijkstra) The route displayed is sometimes wrong.
- (Dijkstra) If the user selects a new destination node after already selecting one, the old one will not be repainted unvisited.

Possible future improvements/additions: 
- [30/10/19] Merge the PaintVisited/PaintUnvisited into one method (repeated code).
- Edge weight checkbox, allowing the algorithm to be executed on both a weighted and non-weighted graph. 
- Allow the user to create custom graphs by placing their own nodes and edges.
- Possibly highlight the edges taken not just the nodes.
