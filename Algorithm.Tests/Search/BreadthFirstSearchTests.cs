using Algorithms.Search;
using DataStructures.Graphs;

namespace Algorithms.Tests.Search
{
    [TestFixture]
    public class BreadthFirstSearchTests
    {
        public static Employee BuildEmployeeGraph()
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

        [Test]
        public void BFS_Test()
        {
            var rootEmployee = BuildEmployeeGraph();
            var searchedEmployee = BreadthFirstSearch.GetEmployee(rootEmployee, "Tina");

            Assert.NotNull(searchedEmployee);
        }
    }
}
