using System;

namespace TASK.BLL.ViewModels
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
    }
}
