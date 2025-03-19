using DataStructures.Graphs;

namespace Algorithms.Search;

public class DephFirstSearchGraph
{
    /*
        1. Check if the current employee has a matching name, if so, return that employee.
        2. Loop through each co-worker and conduct a recursive search.
    */

    // This method performs a depth-first search to find an employee by name in a graph of employees.
    public static Employee? Search(Employee employee, string employeeName, HashSet<Employee>? employeesSeen = null)
    {
        // If the employee is null, throw an exception.
        if (employee is null)
        {
            throw new InvalidOperationException();
        }

        // Initialize the set of seen employees if it is null.
        employeesSeen ??= [];

        // If the current employee's name matches the search name, return the employee.
        if (employee.Name.Equals(employeeName))
        {
            return employee;
        }

        Employee? found = null;

        // Loop through each co-worker of the current employee.
        foreach (Employee coworker in employee.CoWorkers)
        {
            // If the co-worker has not been seen yet, perform a recursive search.
            if (!employeesSeen.Contains(coworker))
            {
                found = Search(coworker, employeeName, employeesSeen);

                // If a matching employee is found, break the loop.
                if (found is object)
                {
                    break;
                }
            }
        }

        // Add the current employee to the set of seen employees.
        employeesSeen.Add(employee);

        // Return the found employee, or null if no match was found.
        return found;
    }

}