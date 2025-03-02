using System;
using System.Collections.Generic;

namespace Algorithms
{
    /// <summary>
    /// Contains backtracking algorithm implementations and examples.
    /// Backtracking is a general algorithm for finding solutions to computational problems
    /// that incrementally builds candidates to the solutions and abandons a candidate
    /// ("backtracks") as soon as it determines the candidate cannot possibly lead to a valid solution.
    /// </summary>
    public static class Backtracking
    {
        /// <summary>
        /// Solves the N-Queens problem using backtracking.
        /// The N-Queens problem is to place N queens on an NxN chessboard so that no two queens attack each other.
        /// </summary>
        /// <param name="boardSize">Size of the board (N)</param>
        /// <returns>A list of valid queen placements, where each placement is represented as a list of column positions.</returns>
        public static List<List<int>> SolveNQueens(int boardSize)
        {
            if (boardSize <= 0)
                throw new ArgumentException("Board size must be positive", nameof(boardSize));

            var solutions = new List<List<int>>();
            var currentPlacement = new List<int>();
            
            SolveNQueensBacktrack(boardSize, 0, currentPlacement, solutions);
            
            return solutions;
        }
        
        /// <summary>
        /// Recursive backtracking method to solve the N-Queens problem.
        /// </summary>
        /// <param name="boardSize">Size of the board</param>
        /// <param name="row">Current row being processed</param>
        /// <param name="currentPlacement">Current queen placements</param>
        /// <param name="solutions">List to collect valid solutions</param>
        private static void SolveNQueensBacktrack(
            int boardSize, 
            int row, 
            List<int> currentPlacement, 
            List<List<int>> solutions)
        {
            // Base case: If all queens are placed, we have a valid solution
            if (row == boardSize)
            {
                // Add a copy of the current placement to solutions
                solutions.Add(new List<int>(currentPlacement));
                return;
            }
            
            // Try placing a queen in each column of the current row
            for (int col = 0; col < boardSize; col++)
            {
                if (IsValidPlacement(currentPlacement, row, col))
                {
                    // Place queen
                    currentPlacement.Add(col);
                    
                    // Recurse to place queens in subsequent rows
                    SolveNQueensBacktrack(boardSize, row + 1, currentPlacement, solutions);
                    
                    // Backtrack: remove the queen from this position
                    currentPlacement.RemoveAt(currentPlacement.Count - 1);
                }
            }
        }
        
        /// <summary>
        /// Checks if placing a queen at the given row and column is valid.
        /// </summary>
        /// <param name="currentPlacement">Current queen placements (positions represented as column indices)</param>
        /// <param name="row">Row to check</param>
        /// <param name="col">Column to check</param>
        /// <returns>True if placement is valid, false otherwise</returns>
        private static bool IsValidPlacement(List<int> currentPlacement, int row, int col)
        {
            // Check against each previously placed queen
            for (int placedRow = 0; placedRow < currentPlacement.Count; placedRow++)
            {
                int placedCol = currentPlacement[placedRow];
                
                // Check if same column
                if (placedCol == col)
                    return false;
                
                // Check if same diagonal (check if row difference equals column difference)
                int rowDifference = Math.Abs(placedRow - row);
                int colDifference = Math.Abs(placedCol - col);
                
                if (rowDifference == colDifference)
                    return false;
            }
            
            return true;
        }
        
        /// <summary>
        /// Prints a representation of the board with queens placed.
        /// </summary>
        /// <param name="queensPlacement">Placement of queens on the board</param>
        public static void PrintQueensBoard(List<int> queensPlacement)
        {
            int boardSize = queensPlacement.Count;
            
            for (int row = 0; row < boardSize; row++)
            {
                string rowStr = string.Empty;
                for (int col = 0; col < boardSize; col++)
                {
                    rowStr += queensPlacement[row] == col ? " Q " : " . ";
                }
                Console.WriteLine(rowStr);
            }
            Console.WriteLine();
        }
        
        /// <summary>
        /// Example usage of the N-Queens problem.
        /// </summary>
        public static void NQueensExample()
        {
            // Solve for a 4x4 board
            int boardSize = 4;
            var solutions = SolveNQueens(boardSize);
            
            Console.WriteLine($"Found {solutions.Count} solutions for {boardSize}x{boardSize} board:");
            foreach (var solution in solutions)
            {
                PrintQueensBoard(solution);
            }
        }
    }
}
