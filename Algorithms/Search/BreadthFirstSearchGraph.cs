using DataStructures.Graphs;
using System;
using System.Collections.Generic;

namespace Algorithms.Search
{
    public static class BreadthFirstSearchGraph
    {
        /// <summary>
        /// Performs a breadth-first search to find an employee by name.
        /// </summary>
        /// <param name="root">The root employee to start the search from.</param>
        /// <param name="employeeName">The name of the employee to search for.</param>
        /// <returns>The employee if found, otherwise null.</returns>
        public static Employee? Search(this Employee root, string employeeName)
        {
            // Initialize a queue to manage the breadth-first search
            var queue = new Queue<Employee>();
            // Initialize a set to keep track of seen employees to avoid cycles
            var seen = new HashSet<Employee>();

            // Enqueue the root employee and mark as seen
            queue.Enqueue(root);
            seen.Add(root);

            // Continue the search while there are employees in the queue
            while (queue.Count > 0)
            {
                // Dequeue the next employee to process
                Employee employee = queue.Dequeue();

                // Check if the current employee's name matches the search name
                if (employeeName.Equals(employee.Name))
                {
                    return employee; // Return the employee if found
                }

                // Enqueue all unseen co-workers of the current employee
                foreach (Employee coWorker in employee.CoWorkers)
                {
                    if (!seen.Contains(coWorker))
                    {
                        seen.Add(coWorker); // Mark co-worker as seen
                        queue.Enqueue(coWorker); // Enqueue co-worker for further processing
                    }
                }
            }

            // Return null if the employee was not found
            return null;
        }
    }
}
