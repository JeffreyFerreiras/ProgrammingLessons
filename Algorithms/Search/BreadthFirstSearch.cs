using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class BreadthFirstSearch
    {
        public Employee BuildEmployeeGraph()
        {
            Employee Eva = new Employee("Eva");
            Employee Sophia = new Employee("Sophia");
            Employee Brian = new Employee("Brian");
            Eva.AddSubordinate(Sophia);
            Eva.AddSubordinate(Brian);

            Employee Lisa = new Employee("Lisa");
            Employee Tina = new Employee("Tina");
            Employee John = new Employee("John");
            Employee Mike = new Employee("Mike");
            Sophia.AddSubordinate(Lisa);
            Sophia.AddSubordinate(John);
            Brian.AddSubordinate(Tina);
            Brian.AddSubordinate(Mike);

            return Eva;
        }

        public Employee GetEmployee(Employee root, string employeeName)
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

                foreach (var subordinate in employee.Subordinates)
                {
                    if (!seen.Contains(subordinate))
                    {
                        seen.Add(subordinate);
                        queue.Enqueue(subordinate);
                    }
                }
            }

            return null;
        }
    }
}
