namespace Algorithms.Search;

public class DephFirstSearchGrid
{

    /// <summary>
    /// Performs a depth-first search on a 2D grid to find the target value.
    /// </summary>
    /// <param name="grid">2D array representing the grid.</param>
    /// <param name="row">The current row index.</param>
    /// <param name="col">The current column index.</param>
    /// <param name="target">The target integer to search for.</param>
    /// <param name="visited">A set to track visited positions to avoid cycles.</param>
    /// <returns>
    /// A tuple (row, col) representing the position of the target if found, otherwise null.
    /// </returns>
    public static (int row, int col)? Search(
        int[,] grid,
        int row,
        int col,
        int target,
        HashSet<(int, int)>? visited = null)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        // Check for out of bounds.
        if (row < 0 || row >= rows || col < 0 || col >= cols)
        {
            return null;
        }

        visited ??= new HashSet<(int, int)>();

        // If already visited, skip.
        if (visited.Contains((row, col)))
        {
            return null;
        }

        // Mark the current cell as visited.
        visited.Add((row, col));

        // Check if the current cell contains the target.
        if (grid[row, col] == target)
        {
            return (row, col);
        }

        // Recursively search the adjacent cells: up, down, left, right.
        var found = Search(grid, row - 1, col, target, visited);
        if (found is not null) return found;

        found = Search(grid, row + 1, col, target, visited);
        if (found is not null) return found;

        found = Search(grid, row, col - 1, target, visited);
        if (found is not null) return found;

        found = Search(grid, row, col + 1, target, visited);
        if (found is not null) return found;

        // Return null if the target was not found.
        return null;
    }
}