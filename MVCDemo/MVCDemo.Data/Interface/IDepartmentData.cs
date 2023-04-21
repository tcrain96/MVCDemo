using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IDepartmentData
    {
        IEnumerable<Department> GetData();
        Department GetEmployeeById(int id);
    }
}
