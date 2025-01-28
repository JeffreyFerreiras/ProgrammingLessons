using Algorithms.Search;
using DataStructures.Graphs;
using NUnit.Framework;

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
            Eva.AddCoWorker(Sophia);
            Eva.AddCoWorker(Brian);

            Employee Lisa = new Employee("Lisa");
            Employee Tina = new Employee("Tina");
            Employee John = new Employee("John");
            Employee Mike = new Employee("Mike");
            Sophia.AddCoWorker(Lisa);
            Sophia.AddCoWorker(John);
            Brian.AddCoWorker(Tina);
            Brian.AddCoWorker(Mike);

            return Eva;
        }

        [Test]
        public void BFS_Test()
        {
            var rootEmployee = BuildEmployeeGraph();
            var searchedEmployee = BreadthFirstSearch.Search(rootEmployee, "Tina");

            Assert.That(searchedEmployee, Is.Not.Null);
        }
    }
}
