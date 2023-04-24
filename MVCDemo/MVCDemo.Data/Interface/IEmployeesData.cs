using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> GetData();
        Employee GetEmployeeById(int id);
    }
}
