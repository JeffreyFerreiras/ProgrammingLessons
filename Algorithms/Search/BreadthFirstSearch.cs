using DataStructures.Graphs;
using System.Collections.Generic;

namespace Algorithms.Search
{
    public static class BreadthFirstSearch
    {
        public static Employee GetEmployee(this Employee root, string employeeName)
        {
            var queue = new Queue<Employee>();
            var seen = new HashSet<Employee>();

            queue.Enqueue(root);
            seen.Add(root);

            while (queue.Count > 0)
            {
                Employee employee = queue.Dequeue();

                if (employeeName.Equals(employee.Name))
                {
                    return employee;
                }

                foreach (Employee coWorker in employee.CoWorkers)
                {
                    if (!seen.Contains(coWorker))
                    {
                        seen.Add(coWorker);
                        queue.Enqueue(coWorker);
                    }
                }
            }

            return null;
        }
    }
}
