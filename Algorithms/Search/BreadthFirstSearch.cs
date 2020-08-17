using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                foreach (var coWorker in employee.CoWorkers)
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
