using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TASK.BLL.ViewModels;

namespace TASK.BLL.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployees();

        Task<EmployeeModel> CreateEmployee (EmployeeCreateModel model);

        Task<EmployeeModel> GetEmployeeById(Guid Id);

        Task<EmployeeModel> UpdateEmployee(EmployeeModel model);

        void DeleteEmployeeById(Guid Id);
    }
}
