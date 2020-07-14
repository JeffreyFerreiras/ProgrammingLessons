using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graph
    {
        public class Node
        {
            private int Id { get; set; }
            LinkedList<Node> AdjacentNodes { get; } = new LinkedList<Node>();

            private Node(int id)
            {
                this.Id = id;
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
