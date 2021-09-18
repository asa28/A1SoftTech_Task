using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TASK.Core.UnitOfWork;
using TASK.BLL.ViewModels;
using AutoMapper;
using TASK.DAL.Models;

namespace TASK.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }





        /// <summary>
        /// All EndPoints for the required Entity
        /// </summary>
        /// <returns></returns>
        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var EntityList = _unitOfWork.EmployeeRepository.GetAll();
            var ModelList = _mapper.Map<List<EmployeeModel>>(EntityList);
            return ModelList;
        }

        public async Task<EmployeeModel> CreateEmployee(EmployeeCreateModel model)
        {
            var EntityModel = _mapper.Map<Employee>(model);
            _unitOfWork.EmployeeRepository.Add(EntityModel);
            _unitOfWork.SaveChanges();
            var viewModel = _mapper.Map<EmployeeModel>(EntityModel);
            return viewModel;
        }

        public async Task<EmployeeModel> GetEmployeeById(Guid Id)
        {
            var EntityModel = _unitOfWork.EmployeeRepository.FindById(Id);
            var model = _mapper.Map<EmployeeModel>(EntityModel);
            return model;
        }

        public async Task<EmployeeModel> UpdateEmployee(EmployeeModel model)
        {
            var ma = _mapper.Map<Employee>(model);
            _unitOfWork.EmployeeRepository.Update(ma);
            _unitOfWork.SaveChanges();
            return model;
        }

        public void DeleteEmployeeById(Guid Id)
        {
            _unitOfWork.EmployeeRepository.DeleteById(Id);
            _unitOfWork.SaveChanges();
        }
    }
}