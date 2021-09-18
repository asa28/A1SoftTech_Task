using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TASK.BLL.Services;
using TASK.BLL.ViewModels;

namespace TASK.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _EmployeeService = employeeService;
        }


        [HttpGet("list-All-Employees")]
        public Task<List<EmployeeModel>> ListAllEmployees()
        {
            var res = _EmployeeService.GetAllEmployees();
            return res;
        }

        [HttpPost("add-Employee")]
        public Task<EmployeeModel> AddEmployee(EmployeeCreateModel model)
        {
            var res = _EmployeeService.CreateEmployee(model);
            return res;
        }

        [HttpGet("view-Employee")]
        public Task<EmployeeModel> ViewEmployee(Guid id)
        {
            var res = _EmployeeService.GetEmployeeById(id);
            return res;
        }

        [HttpPut("edit-Employee")]
        public Task<EmployeeModel> EditEmployee(EmployeeModel model)
        {
            var res = _EmployeeService.UpdateEmployee(model);
            return res;
        }

        [HttpDelete("remove-Employee")]
        public void RemoveEmployee(Guid id)
        {
           _EmployeeService.DeleteEmployeeById(id);
        }
    }
}
