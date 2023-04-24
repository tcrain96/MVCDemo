using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IDepartmentsData
    {
        IEnumerable<Department> GetData();
        Department GetEmployeeById(int id);
    }
}
