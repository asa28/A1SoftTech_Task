using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TASK.DAL.Models
{
    public class EmployeeTax
    {
        [Key]
        public Guid Id { get; set; } = new Guid();


        [ForeignKey("Employee")]
        public Guid EmpId { get; set; }
        public Employee Employee { get; set; }


        public float Tax { get; set; }

        public float NetSalary { get; set; }
    }
}
