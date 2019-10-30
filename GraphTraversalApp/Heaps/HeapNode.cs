namespace GraphTraversalApp.Heaps
{
    using GraphTraversalApp.GraphObjects;
    class HeapNode
    {
        //The heap element will contain the graph node so 
        private Node nodeElement;
        private int distFromStart;

        public Node NodeElement
        {
            get
            {
                return this.nodeElement;
            }
            set
            {
                this.nodeElement = value;
            }
        }
        public int DistFromStart
        {
            get
            {
                return this.distFromStart;
            }
            set
            {
                this.distFromStart = value;
            }
        }

        //Constructor without specified distance from start node, sends ~infinity as default
        public HeapNode(Node graphNode)
            : this(graphNode, int.MaxValue)
        {
        }

        public HeapNode(Node graphNode, int distFromStart)
        {
            this.nodeElement = graphNode;
            this.distFromStart = distFromStart;
        }
    }
}
