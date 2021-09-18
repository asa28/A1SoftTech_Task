using System;
using System.ComponentModel.DataAnnotations;

namespace TASK.DAL.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public int Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public float Salary { get; set; }

    }
}
