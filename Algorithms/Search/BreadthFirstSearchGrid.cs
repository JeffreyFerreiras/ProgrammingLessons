namespace Algorithms.Search
{
    public static class GridBreadthFirstSearch
    {
        /// <summary>
        /// Performs a breadth-first search on a 2D grid to find the target value.
        /// </summary>
        /// <param name="grid">2D array representing the grid.</param>
        /// <param name="startRow">The starting row index.</param>
        /// <param name="startCol">The starting column index.</param>
        /// <param name="target">The target integer to search for.</param>
        /// <returns>
        /// A tuple (row, col) representing the position of the target if found, otherwise null.
        /// </returns>
        public static (int row, int col)? Search(int[,] grid, int startRow, int startCol, int target)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (startRow < 0 || startRow >= rows || startCol < 0 || startCol >= cols)
            {
                throw new ArgumentException("Starting coordinates are out of bounds.");
            }

            // Define the possible directions: up, down, left, right.
            int[][] directions =
            [
                [-1, 0], // Up
                [1, 0],  // Down
                [0, -1], // Left
                [0, 1]   // Right
            ];

            var queue = new Queue<(int row, int col)>();
            var seen = new HashSet<(int, int)>();

            queue.Enqueue((startRow, startCol));
            seen.Add((startRow, startCol));

            while (queue.Count > 0)
            {
                var (currentRow, currentCol) = queue.Dequeue();

                // Check if the current cell contains the target value.
                if (grid[currentRow, currentCol] == target)
                {
                    return (currentRow, currentCol);
                }

                // Process all valid adjacent cells.
                foreach (var dir in directions)
                {
                    int newRow = currentRow + dir[0];
                    int newCol = currentCol + dir[1];

                    if (newRow >= 0 && newRow < rows &&
                        newCol >= 0 && newCol < cols &&
                        !seen.Contains((newRow, newCol)))
                    {
                        queue.Enqueue((newRow, newCol));
                        seen.Add((newRow, newCol));
                    }
                }
            }

            // Return null if the target was not found.
            return null;
        }
    }
}
