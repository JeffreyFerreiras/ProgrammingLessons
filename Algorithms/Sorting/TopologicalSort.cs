namespace Algorithms.Sorting;

public static class TopologicalSort
{
    /// <summary>
    /// Performs topological sort on a directed acyclic graph (DAG) using Kahn's algorithm.
    /// </summary>
    /// <param name="graph">Adjacency list representing the graph, where each key is a node and the value is a list of its neighbors.</param>
    /// <returns>A list of nodes in topological order, or null if the graph contains a cycle.</returns>
    public static List<T> KahnSort<T>(Dictionary<T, List<T>> graph) where T : notnull
    {
        // Calculate in-degrees for each node. The in-degree of a node is the number of edges coming into it.
        Dictionary<T, int> inDegree = [];
        foreach (var node in graph.Keys)
        {
            inDegree[node] = 0; // Initialize in-degree to 0 for all nodes.
        }

        // Iterate through the adjacency list to populate the in-degrees.
        foreach (var node in graph.Keys)
        {
            foreach (var neighbor in graph[node])
            {
                // Increment the in-degree of the neighbor.
                if (!inDegree.TryAdd(neighbor, 1))
                {
                    inDegree[neighbor]++;
                }
            }
        }

        // Enqueue nodes with an in-degree of 0 into the queue.  These are the starting nodes.
        Queue<T> queue = new(inDegree.Where(kvp => kvp.Value == 0).Select(kvp => kvp.Key));

        // Initialize a list to store the sorted elements.
        List<T> sortedList = [];

        // Keep track of visited count to detect cycles.
        int visitedCount = 0;

        // Process elements from the queue until it is empty.
        while (queue.Count > 0)
        {
            // Dequeue a node from the queue.
            T node = queue.Dequeue();

            // Add the node to the sorted list.
            sortedList.Add(node);

            // Increment the visited count.
            visitedCount++;

            // Iterate through the neighbors of the dequeued node.
            if (graph.ContainsKey(node))
            {
                foreach (var neighbor in graph[node])
                {
                    // Reduce the in-degree of the neighbor.
                    inDegree[neighbor]--;

                    // If the in-degree of the neighbor becomes 0, enqueue it.
                    if (inDegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        // Check for cycle. If the graph has a cycle, the visited count will not match the number of nodes.
        if (visitedCount != graph.Count)
        {
            // Cycle exists, topological sort not possible.
            return [];
        }

        // Return the sorted list.
        return sortedList;
    }
}
