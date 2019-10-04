using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversalApp.GraphObjects
{
    //Represents a graph of node objects
    public class Graph
    {
        //Fields
        private int noNodes;
        private List<Node> nodeList;

        //Properties
        public int NoNodes
        {
            get
            {
                return this.noNodes;
            }
            set
            {
                this.noNodes = value;
            }
        }
        public List<Node> NodeList
        {
            get
            {
                return this.nodeList;
            }
            set
            {
                this.nodeList = value;
            }
        }

        //Constructor
        public Graph()
        {
            this.noNodes = 0;
            this.nodeList = new List<Node>();
        }

        //Methods
        public void AddNode(string name)
        {
            nodeList.Add(new Node(name, this.noNodes));
            this.noNodes++;
        }
        //Allows the removal of a node using only its name
        public void RemoveNode(string name)
        {
            nodeList.Remove(nodeList.Find(x => x.Name == name));
            this.noNodes--;
        }
        //Adds an edge between two nodes
        public void AddEdge(Node a, Node b, int weight)
        {
            a.EdgeList.Add(b, weight);
            b.EdgeList.Add(a, weight);
        }
        //Another implementation which can operate with only the graph and two given node indices
        public void AddEdge(Graph graph, int indexNodeA, int indexNodeB, int weight)
        {
            graph.nodeList.Find(x => x.Index == indexNodeA).EdgeList.Add(graph.nodeList.Find(x => x.Index == indexNodeB), weight);
            graph.nodeList.Find(x => x.Index == indexNodeB).EdgeList.Add(graph.nodeList.Find(x => x.Index == indexNodeA), weight);
        }
    }   
}
