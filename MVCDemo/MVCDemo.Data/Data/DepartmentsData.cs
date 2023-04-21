using MVCDemo.Data.Interface;
using MVCDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Data
{
    public class DepartmentsData : IDepartmentsData
    {
        public IEnumerable<Departments> GetData()
        {
            throw new NotImplementedException();
        }

        public Departments GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
