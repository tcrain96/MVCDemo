namespace MVCDemo.Web.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? DepartmentTitle { get; set; }
        public Employee? Employee { get; set; }
    }
}
