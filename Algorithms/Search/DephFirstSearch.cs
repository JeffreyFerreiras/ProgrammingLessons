using DataStructures.Graphs;

namespace Algorithms.Search;

public class DephFirstSearch
{
    /*
			1. check if the current employee has matching name, if so, return that employee
        2. loop through each co-workerand conduct a recursive search.

		 */

    public Employee? Search(Employee employee, string employeeName, HashSet<Employee>? employeesSeen = null)
    {
        if (employee is null)
        {
            throw new InvalidOperationException();
        }

        employeesSeen ??= [];

        if (employee.Name.Equals(employeeName))
        {
            return employee;
        }

        Employee? found = null;

        foreach (Employee coworker in employee.CoWorkers)
        {
            if (!employeesSeen.Contains(coworker))
            {
                found = Search(coworker, employeeName, employeesSeen);

                if (found is object)
                {
                    break;
                }
            }
        }

        employeesSeen.Add(employee);

        return found;
    }
}