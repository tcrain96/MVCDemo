using MVCDemo.Data.Interface;
using MVCDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Data
{
    public class EmployeesData : IEmployeesData
    {
        private readonly MVCDemoDBContext db;

        public EmployeesData(MVCDemoDBContext db) {
            this.db = db;
        }

        public IEnumerable<Employee> GetData()
        {
            return db.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
