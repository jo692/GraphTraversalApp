namespace GraphTraversalApp.Heaps
{
    using System;
    using GraphTraversalApp.GraphObjects;
    class MinHeap : HeapTree
    {
        public MinHeap()
            : base()
        {

        }
        //Add a node to the end of the minHeap (leftmost position at the bottom of the tree), then HeapifyUp
        public void Enqueue(Node graphNode, int distFromStart)
        {
            HeapNode newNode = new HeapNode(graphNode, distFromStart);

            //Add this node to the end of the list, the leftmost position at the bottom of the tree
            this.NodeList.Add(newNode);
            this.NumberNodes++;

            //Ensure the smallest element is at the root 
            this.HeapifyUp();

        }
        //Remove the root node, then HeapifyDown. No need to return since we have access to the root
        public void Dequeue()
        {
            //Remove it and deincrement the number of elements in the heap
            this.NodeList.RemoveAt(0);
            this.NumberNodes--;

            if (this.NumberNodes != 0)
            {
                //Ensure the smallest element is at root
                this.HeapifyDown();
            }
        }
        //Function which assures the smallest element is always at the root (Min heap) after an element has been inserted
        public void HeapifyUp()
        {
            //Get the index of the last element
            int index = this.NumberNodes - 1;

            //Loop to run until we reach the root node and the smallest value is currently not at the root
            while (this.ParentCheck(index) != -1 && this.NodeList[ParentCheck(index)].DistFromStart > this.NodeList[index].DistFromStart)
            {
                //Swap the position of the child and its parent
                this.NodeSwap(index, ParentCheck(index));
                //Set the index to be the parent, then repeat the process
                index = ParentCheck(index);
            }
        }
        //Ensure the smallest element is at the top after an element has been dequeued from the root.
        public void HeapifyDown()
        {
            //Set the start index to be the root
            int index = 0;
            //Run until we have reached the bottom of the heap
            while (this.LeftChildCheck(index) != -1)
            {
                //Initialise smallestChildIndex before finding the real index
                int smallestChildIndex = 0;

                //Ensure there is a right child
                if (this.RightChildCheck(index) == -1)
                {
                    smallestChildIndex = this.LeftChildCheck(index);
                }
                //There is a right child, so find out which is smallest
                else
                {
                    //Ternary function to find the smallest of the children, if they're the same then left child is used
                    smallestChildIndex = this.NodeList[this.LeftChildCheck(index)].DistFromStart < this.NodeList[this.RightChildCheck(index)].DistFromStart ? this.LeftChildCheck(index) : this.RightChildCheck(index);
                }

                //Check if current element is smaller than the smallest child, if so end
                if (this.NodeList[index].DistFromStart < this.NodeList[smallestChildIndex].DistFromStart)
                {
                    return;
                }
                //If the child is smaller, swap its position with the parent
                else
                {
                    this.NodeSwap(smallestChildIndex, index);
                }
                //Move down the tree to the next child
                index = smallestChildIndex;
            }
        }
        //Checks if the node at 'index' as a parent, returns -1 if no parent, returns parent index if found
        public int ParentCheck(int index)
        {
            //If the element index is 0, then it is the root
            if (index == 0)
            {
                return -1;
            }
            //Else return the parent index
            else
            {
                return (index - 1) / 2;
            }
        }
        //Checks if a node has a left child node, returns -1 if not or its index if so
        public int LeftChildCheck(int index)
        {
            int leftChildIndex = (index * 2) + 1;

            //If its index is greater than the index of the last node, then no left child
            if (leftChildIndex > this.NumberNodes - 1)
            {
                return -1;
            }
            else
            {
                return leftChildIndex;
            }
        }
        public int RightChildCheck(int index)
        {
            int rightChildIndex = (index * 2) + 2;
            if (rightChildIndex > this.NumberNodes - 1)
            {
                return -1;
            }
            else
            {
                return rightChildIndex;
            }
        }
        //Test function for printing the elements of the heap in order
        public void PrintHeap()
        {
            Console.WriteLine("Current Heap:");
            foreach (HeapNode node in this.NodeList)
            {
                Console.WriteLine($"{node.NodeElement.Name} ({node.DistFromStart})");
            }
        }
        //Checks if the node is in the heap, if so returns its index, if not returns -1;
        public int HeapElementCheck(string nodeName)
        {
            //loop through all elements until the node with the given name is found, return its index
            for (int i = 0; i < this.NumberNodes; i++)
            {
                if (this.NodeList[i].NodeElement.Name == nodeName)
                {
                    return i;
                }
            }
            return -1;
        }
        //Updates the distance of a node from the start, then heapifies
        public void UpdateNodeDistance(int heapNodeIndex, int newDistance)
        {
            this.NodeList[heapNodeIndex].DistFromStart = newDistance;
            HeapifyUp(); //Change for HeapifyUpFromIndex in future
        }

    }
}
