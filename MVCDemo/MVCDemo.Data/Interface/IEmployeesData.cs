using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IEmployeesData
    {
        IEnumerable<Employees> GetData();
        Employees GetEmployeeById(int id);
    }
}
