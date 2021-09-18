using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;
using TASK.DAL.Context;
using TASK.API.HelperMethods;
using TASK.BLL.AutoMapper;

namespace A1SoftTech_Task
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        // This method gets called by the runtime.
        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region Automapper
            
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new TaskAutoMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            
            
            services.AddSingleton(mapper);

            #endregion



            services.AddDbContext<TaskDbContext>
                (opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            ServicesInjection.AddServicesInjection(services);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "A1SoftTech_Task", Version = "v1" });
            });
        }

        
        
        // This method gets called by the runtime.
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "A1SoftTech_Task v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
