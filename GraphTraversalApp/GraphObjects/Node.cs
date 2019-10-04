using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversalApp.GraphObjects
{
    public class Node
    {
        //Fields
        private string name;
        private int index;
        private Dictionary<Node, int> edgeList;

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }
        public Dictionary<Node, int> EdgeList
        {
            get
            {
                return this.edgeList;
            }
            set
            {
                this.edgeList = value;
            }
        }

        //Constructor
        public Node(string name, int index)
        {
            this.name = name;
            this.index = index;
            this.edgeList = new Dictionary<Node, int>();
        }
    }
}
