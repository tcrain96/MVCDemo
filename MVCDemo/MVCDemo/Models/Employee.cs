using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Web.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

    }
}
