using DataStructures.Graphs;

namespace Algorithms.Search
{
    public class DephFirstSearch
    {
        /*
			1. check if the current employee has matching name, if so, return that employee
            2. loop through each co-workerand conduct a recursive search.

		 */

        public Employee Search(Employee employee, string employeeName, HashSet<Employee> employeesSeen = null)
        {
            if (employee is null)
            {
                throw new InvalidOperationException();
            }

            HashSet<Employee> seen = employeesSeen ?? new HashSet<Employee>();

            if (employee.Name.Equals(employeeName))
            {
                return employee;
            }

            Employee found = null;

            foreach (Employee coworker in employee.CoWorkers)
            {
                if (!seen.Contains(coworker))
                {
                    found = Search(coworker, employeeName, seen);

                    if (found is object)
                    {
                        break;
                    }
                }
            }

            seen.Add(employee);

            return found;
        }

		public Employee SearchPractice(Employee employee, string name, HashSet<Employee> seen = null)
		{
			seen = seen ?? new HashSet<Employee>();

			if (employee.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
			{
				return employee;
			}

			foreach (Employee coworker in employee.CoWorkers) 
			{
				if (!seen.Contains(coworker))
				{
					Employee found = SearchPractice(coworker, name, seen);

					if (found is object) 
					{
						return found;
					}
				}
			}

			seen.Add(employee);

			return null;
		}
    }
}