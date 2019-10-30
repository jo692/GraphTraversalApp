namespace GraphTraversalApp.Heaps
{
    using System.Collections.Generic;
    class HeapTree
    {
        private HeapNode root;
        private List<HeapNode> nodeList;
        private int numberNodes;
        //private int height;

        public HeapNode Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }
        public List<HeapNode> NodeList
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
        public int NumberNodes
        {
            get
            {
                return this.numberNodes;
            }
            set
            {
                this.numberNodes = value;
            }
        }

        public HeapTree()
        {
            this.root = null;
            this.nodeList = new List<HeapNode>();
            this.numberNodes = 0;
        }

        //Function to swap a child node with its parent node
        public void NodeSwap(int childIndex, int parentIndex)
        {
            //Temp variable to hold node while we swap them
            HeapNode tempNode = nodeList[childIndex];

            nodeList[childIndex] = nodeList[parentIndex];
            nodeList[parentIndex] = tempNode;
        }
    }
}
