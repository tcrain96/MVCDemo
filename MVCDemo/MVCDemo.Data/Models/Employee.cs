﻿using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public Department? Department { get; set; }

    }
}