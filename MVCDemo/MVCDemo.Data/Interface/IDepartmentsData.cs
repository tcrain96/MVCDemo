using MVCDemo.Data.Models;

namespace MVCDemo.Data.Interface
{
    public interface IDepartmentsData
    {
        IEnumerable<Departments> GetData();
        Departments GetEmployeeById(int id);
    }
}
