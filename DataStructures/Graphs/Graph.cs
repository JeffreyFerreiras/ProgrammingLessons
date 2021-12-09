using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class Graph
    {
        public class Node
        {
            private int Id { get; set; }
            private LinkedList<Node> AdjacentNodes { get; } = new LinkedList<Node>();

            private Node(int id)
            {
                Id = id;
            }
        }

        protected Node GetNode(int id)
        {
            throw new NotImplementedException();
        }

        public bool HasPathDFS(int sourceId, int destinationId)
        {
            throw new NotImplementedException();
        }
    }
}
