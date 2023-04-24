
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Data.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DepartmentTitle { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }


    }
}
