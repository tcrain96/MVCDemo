using MVCDemo.Data.Interface;
using MVCDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Data
{
    public class EmployeeData : IEmployeeData
    {
        public IEnumerable<Employee> GetData()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
