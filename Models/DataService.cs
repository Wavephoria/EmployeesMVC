namespace EmployeesMVC.Models;

public class DataService
{
    private List<Employee> _employees = new List<Employee>()
    {
        new Employee { Id = 1, Name = "Lars", Email = "lars.eriksson@hotmail.com"},
        new Employee { Id = 4, Name = "Erik", Email = "erik.eriksson@hotmail.com"},
        new Employee { Id = 6, Name = "Jonas", Email = "jonas.eriksson@hotmail.com"},
        new Employee { Id = 8, Name = "Sven", Email = "sven.eriksson@hotmail.com"}
    };

    public void AddEmployee(Employee employee)
    {
        employee.Id = _employees.Count() == 0 ? 1 : _employees.Max(a => a.Id) + 1; 
        _employees.Add(employee);
    }

    public Employee[] GetAll()
    {
        return _employees.ToArray();
    }

    public Employee GetById(int id)
    {
        return _employees.SingleOrDefault(a => a.Id == id);
    }
}