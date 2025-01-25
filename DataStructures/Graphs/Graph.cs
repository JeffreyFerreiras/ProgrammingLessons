namespace DataStructures.Graphs
{
    public class Graph
    {
        public class Node(int id)
        {
            private int Id { get; set; } = id;
            public LinkedList<Node> AdjacentNodes { get; } = new LinkedList<Node>();
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
