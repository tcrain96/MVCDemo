using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetData();
        Employee GetEmployeeById(int id);
    }
}
