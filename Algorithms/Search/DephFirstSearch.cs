using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class DephFirstSearch
    {
		/*
			1. check if the current employee has matching name, if so, return that employee
            2. loop through each co-workerand conduct a recursive search.

		 */
		public Employee Search(Employee employee, string employeeName, HashSet<Employee> empSet = null)
		{
			if(employee is null)
            {
				throw new InvalidOperationException();
            }

			var seen = empSet ?? new HashSet<Employee>();

            if (employee.Name.Equals(employeeName))
            {
                return employee;
            }

            Employee found = null;

            foreach (var coworker in employee.CoWorkers)
            {
                if (!seen.Contains(coworker))
                {
                    found = Search(coworker, employeeName, seen);

                    if(found is object)
                    {
                        break;
                    }
                }
            }

            seen.Add(employee);

            return found;
        }
    }
}
