﻿
namespace MVCDemo.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? DepartmentTitle { get; set; }
        public Employee? Employee { get; set; }
    }
}
