namespace DataStructures.Graphs
{
    /// <summary>
    /// Represents an employee graph
    /// </summary>
    public class Employee
    {
        private List<Employee> _coWorkers = new List<Employee>();

        public IList<Employee> CoWorkers => _coWorkers.ToArray();
        public string Name { get; private set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public void AddCoWorker(Employee employee)
        {
            this._coWorkers.Add(employee);
        }

        public void RemoveCoWorker(Employee employee)
        {
            this._coWorkers.Remove(employee);
        }
    }
}