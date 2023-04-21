using MVCDemo.Data.Interface;
using MVCDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data.Data
{
    public class EmployeesData : IEmployeesData
    {
        public IEnumerable<Employees> GetData()
        {
            throw new NotImplementedException();
        }

        public Employees GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
