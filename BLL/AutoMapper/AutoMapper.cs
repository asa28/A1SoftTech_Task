using AutoMapper;
using TASK.BLL.ViewModels;
using TASK.DAL.Models;

namespace TASK.BLL.AutoMapper
{
    public class TaskAutoMapperProfile :Profile
    {
        public TaskAutoMapperProfile()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Employee, EmployeeCreateModel>().ReverseMap();
        }
    }
}
