using MVCDemo.Data.Interface;
using MVCDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Data
{
    public class DepartmentData : IDepartmentData
    {
        public IEnumerable<Department> GetData()
        {
            throw new NotImplementedException();
        }

        public Department GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
