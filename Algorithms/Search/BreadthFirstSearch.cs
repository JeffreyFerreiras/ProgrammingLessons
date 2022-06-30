using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;

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

		/**
		 hint: When doing a breadth first search, use a queue
		 */

		public static Employee BreadthFirstSearchPractice(Employee root, string name)
		{
			var queue = new Queue<Employee>();
			var seen = new HashSet<Employee>();

			queue.Enqueue(root);
			seen.Add(root);

			while(queue.Count() > 0)
			{
				var employee = queue.Dequeue();

				if (employee.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return employee;
				}

				foreach(var coworker in employee.CoWorkers)
				{
					if (seen.Contains(coworker)) continue;
					queue.Enqueue(coworker);
					seen.Add(coworker);
				}
			}

			return null;
		}
    }
}
