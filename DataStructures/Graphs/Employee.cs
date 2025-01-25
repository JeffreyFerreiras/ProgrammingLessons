namespace DataStructures.Graphs
{
    /// <summary>
    /// Represents an employee graph
    /// </summary>
    public class Employee
    {
        private List<Employee> _subordinates = new List<Employee>();

        public IEnumerable<Employee> CoWorkers => _subordinates.ToArray();
        public string Name { get; private set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public void AddSubordinate(Employee employee)
        {
            this._subordinates.Add(employee);
        }

        public void RemoveSubordinate(Employee employee)
        {
            this._subordinates.Remove(employee);
        }
    }
}