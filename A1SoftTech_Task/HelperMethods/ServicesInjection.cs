using Microsoft.Extensions.DependencyInjection;
using TASK.BLL.Services;
using TASK.Core.IRepositories;
using TASK.Core.Repositories;
using TASK.Core.UnitOfWork;

namespace TASK.API.HelperMethods
{
    public static class ServicesInjection
    {

        public static void AddServicesInjection(this IServiceCollection services)
        {            
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeTaxRepository, EmployeeTaxRepository>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            
            services.AddScoped<IEmployeeService, EmployeeService>();
        }

    }
}
