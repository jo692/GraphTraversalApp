namespace GraphTraversalApp
{
    using GraphTraversalApp.GraphObjects;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class GraphTraversalForm : Form
    {
        //Global variable to hold the graph 
        Graph graph = new Graph();

        //Enables the GraphPanelPaintGraph function to execute upon the New Graph button being pressed
        bool newGraphButtonClicked = false;

        //Global variable for a random number generator
        Random rng = new Random();

        //Some of these may move from global in the future
        Brush unvisitedBrush = new SolidBrush(Color.Crimson);
        Brush visitedBrush = new SolidBrush(Color.Lime);
        Brush blackBrush = new SolidBrush(Color.Black);
        Pen blackPen = new Pen(Color.Black, 3);

        //Global list to hold the graphic associated with each node in the graph
        List<Rectangle> nodesCircles = new List<Rectangle>();

        //Global to hold the name of the start node, by default the startNode will be A (index 0)
        int startNodeIndex = 0;

        public GraphTraversalForm()
        {
            InitializeComponent();
        }

        //Clears the current graph and calls the GraphPanelPaintGraph function which will generate and display a new graph
        private void NewGraphButtonClick(object sender, EventArgs e)
        {
            //Fresh graph upon click so any previous incrementation of noNodes is reset
            graph = new Graph();

            //First clear any current graph of its nodes and illustrations
            nodesCircles.Clear();
               
            //Enable the graph paint function and execute
            newGraphButtonClicked = true;
            graphPanel.Paint += new PaintEventHandler(GraphPanelPaintGraph);
            graphPanel.Refresh();

            //Change prompt label
            promptLabel.Text = "Now click a start node";
        }

        private void BfsButtonClick(object sender, EventArgs e)
        {
            ////Instantiate list to hold the route taken and add start node
            //List<string> route = new List<string>();
            //route.Add(startNode);

            ////Keep track of position within the graph
            //Node currentNode = null;

            ////Try assign the first node to currentNode
            //try
            //{
            //    currentNode = graph.NodeList.Find(x => x.Name == startNode);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid start node, please input a valid node name");
            //}

            ////Instantiate the stack to keep track of node exploration
            //Stack<Node> nodeStack = new Stack<Node>();

            ////Run until every node is in the route
            //while (route.Count != graph.NoNodes)
            //{
            //    //Variable to hold the number of neighbouring nodes which have already been explored, reset when we have new node
            //    int redundantCount = 0;

            //    //Sort the edge list so that the nodes will be added to the route according to which is closest
            //    var sortedEdgeDict = from entry in currentNode.EdgeList orderby entry.Value ascending select entry;
            //    foreach (var edge in sortedEdgeDict)
            //    {
            //        //Run through the edge list, when an unvisited node is found, visit it and push current to stack
            //        if (!route.Contains(edge.Key.Name))
            //        {
            //            //Add it to the route
            //            route.Add(edge.Key.Name);
            //            //Push current to stack for later exploration
            //            nodeStack.Push(currentNode);
            //            //Assign the newly visited node to be the current node
            //            currentNode = edge.Key;
            //            //Break out of this since we now have a new node to explore from
            //            break;
            //        }
            //        //If its already in the route, increment redundantCount
            //        else
            //        {
            //            redundantCount++;
            //            //If every neighbouring node is visited, then we should revert back to the top element of the stack
            //            if (redundantCount == sortedEdgeDict.Count())
            //            {
            //                currentNode = nodeStack.Pop();
            //                break;
            //            }
            //        }
            //    }

            //}
        }
        //Generate and illustrate a new random(ish) graph with between 7 - 10 nodes
        private void GraphPanelPaintGraph(object sender, PaintEventArgs e)
        {
            if (newGraphButtonClicked)
            {
                Graphics g = graphPanel.CreateGraphics();
                g.Clear(Color.White);

                //String array to hold the names of the nodes
                string[] nodeNames = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

                int numberOfNodes = rng.Next(7, 11);

                //Holds the placement of the nodes when drawing
                int x = 0; int y = 180;

                //Adjust the position of the graph depending on the number of nodes, ensuring it's centered
                switch (numberOfNodes)
                {
                    case 7:
                        x = 80;
                        break;
                    case 8:
                        x = 50;
                        break;
                    case 9:
                        x = 30;
                        break;
                    case 10:
                        x = 0;
                        break;
                    default:
                        break;
                }

                //Generate between 7-10 nodes for the graph
                for (int i = 0; i < numberOfNodes; i++)
                {
                    graph.AddNode(nodeNames[i]);
                    x += 50;
                    //If i is even, then the node is to be drawn on the top row
                    if (i % 2 == 0)
                    {
                        y -= 80;
                    }
                    else
                    {
                        y += 80;
                    }
                    //Add the circles to the list so they can be accessed within other functions
                    nodesCircles.Add(new Rectangle(x, y, 20, 20));
                    //Draw and fill them using the unvisited node colour
                    g.DrawEllipse(blackPen, nodesCircles[i]);
                }
                //Cycle through all but the last node
                for (int j = 0; j < graph.NoNodes - 1; j++)
                {
                    int edgeWeight = rng.Next(5, 51);
                    //If we are addressing the second to last node, connect it to the last one only
                    if (j == graph.NoNodes - 2)
                    {
                        graph.AddEdge(graph, j, j + 1, edgeWeight);
                        g.DrawLine(blackPen, nodesCircles[j].X + 8, nodesCircles[j].Y + 4, nodesCircles[j + 1].X + 8, nodesCircles[j + 1].Y + 4);
                        g.DrawString(edgeWeight.ToString(), new Font(this.Font, FontStyle.Bold), blackBrush, ((nodesCircles[j].X + nodesCircles[j + 1].X) / 2) + 14, (nodesCircles[j].Y + nodesCircles[j + 1].Y) / 2);
                    }
                    else
                    {
                        //Each node can have between 1 and 2 forward edges (A can only have edges to B or C, therefore the max edges for a node is 4)
                        for (int k = 1; k < rng.Next(2, 4); k++)
                        {
                            graph.AddEdge(graph, j, j + k, edgeWeight);

                            //Draw this edge using the position of the nodes
                            g.DrawLine(blackPen, nodesCircles[j].X + 8, nodesCircles[j].Y + 4, nodesCircles[j + k].X + 8, nodesCircles[j + k].Y + 4);

                            //If the nodes are at the same Y, then the edge weight should be written sightly higher to clear the edge
                            if (nodesCircles[j].Y == nodesCircles[j + k].Y)
                            {
                                g.DrawString(edgeWeight.ToString(), new Font(this.Font, FontStyle.Bold), blackBrush, (nodesCircles[j].X + nodesCircles[j + k].X) / 2, ((nodesCircles[j].Y + nodesCircles[j + k].Y) / 2) - 10);
                            }
                            //With the diagonal edges, the weight must be moved slightly to the side to avoid the line
                            else
                            {
                                g.DrawString(edgeWeight.ToString(), new Font(this.Font, FontStyle.Bold), blackBrush, ((nodesCircles[j].X + nodesCircles[j + k].X) / 2) + 14, (nodesCircles[j].Y + nodesCircles[j + k].Y) / 2);
                            }
                        }
                    }
                }
                for (int i = 0; i < graph.NoNodes; i++)
                {
                    g.FillEllipse(unvisitedBrush, nodesCircles[i]);
                    //Draw the node name inside the cirle
                    g.DrawString(nodeNames[i], new Font(this.Font, FontStyle.Bold), blackBrush, nodesCircles[i].X + 4, nodesCircles[i].Y + 4);
                }
                newGraphButtonClicked = false;
            }
        }
        //Captures the point of the mouse click, used to determine which start node the user has selected
        private void GraphPanelMouseClick(object sender, MouseEventArgs e)
        {
            //The position of the click
            Point p = new Point(e.X, e.Y);

            //Loop through all nodes to see if the click was within their area
            for(int i = 0; i < nodesCircles.Count; i++)
            {
                //Get the centre of the circle
                Point centre = new Point((nodesCircles[i].X + (nodesCircles[i].Width / 2)), (nodesCircles[i].Y + (nodesCircles[i].Height / 2)));

                //Calculate distance between p and centre
                double xDist = Math.Abs(centre.X - p.X);
                double yDist = Math.Abs(centre.Y - p.Y);
                double radialDistance = Math.Sqrt(Math.Pow(xDist, 2) + Math.Pow(yDist, 2));

                //Check if this distance is less than or equal the circles radius, thus within the circle
                if(radialDistance <= nodesCircles[i].Width / 2)
                {
                    //Change colour of previous start node selection back to red
                    PaintUnvisited(startNodeIndex);
                    //Assign global variable to the index of the start node 
                    startNodeIndex = i;
                    //Change the colour of the start node to green
                    PaintVisited(startNodeIndex);
                    //Change the prompt label text
                    promptLabel.Text = $"Choose a search...";
                }
            }
        }
        //Method used to paint an index green, signifying that it has either been visited or is the start node
        private void PaintVisited(int nodeIndex)
        {
            Graphics g = graphPanel.CreateGraphics();
            g.FillEllipse(visitedBrush, nodesCircles[nodeIndex]);
            g.DrawString(graph.NodeList[nodeIndex].Name, new Font(this.Font, FontStyle.Bold), blackBrush, nodesCircles[nodeIndex].X + 4, nodesCircles[nodeIndex].Y + 4);

        }
        //Counterpart function of PaintVisited
        private void PaintUnvisited(int nodeIndex)
        {
            Graphics g = graphPanel.CreateGraphics();
            g.FillEllipse(unvisitedBrush, nodesCircles[nodeIndex]);
            g.DrawString(graph.NodeList[nodeIndex].Name, new Font(this.Font, FontStyle.Bold), blackBrush, nodesCircles[nodeIndex].X + 4, nodesCircles[nodeIndex].Y + 4);
        }
        
    }
}
