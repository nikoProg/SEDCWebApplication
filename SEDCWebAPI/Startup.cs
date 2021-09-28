using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SEDCWebAPI.Repositories.Implementations;
using SEDCWebAPI.Repositories.Interfaces;
using SEDCWebAPI.Services.Implementations;
using SEDCWebAPI.Services.Interfaces;
using SEDCWebApplication.BLL.Logic.Implementations;
using SEDCWebApplication.BLL.Logic.Interfaces;
//using SEDCWebApplication.DAL.Data.Implementations;
//using SEDCWebApplication.DAL.Data.Interfaces;
using SEDCWebApplication.DAL.DatabaseFactory;
using SEDCWebApplication.DAL.DatabaseFactory.Implementations;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDCWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    });
            });

            services.AddControllers();

            services.AddAutoMapper(typeof(ProductManager));

            services.AddScoped<IProductRepository, DatabaseProductRepository>();
            services.AddScoped<IEmployeeRepository, DatabaseEmployeeRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDataService, DataService>();

            //BLL
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IEmployeeManager, EmployeeManager>();
            services.AddScoped<IOrderManager, OrderManager>();

            //DAL
            //direct database approach DAL.data
            //services.AddScoped<IProductDAL, ProductDAL>();

            //entity framework repositories, entityfactory, databasefactory
            services.AddScoped<IUserDAL, UserRepository>();
            services.AddScoped<IProductDAL, ProductRepository>();
            services.AddScoped<IEmployeeDAL, EmployeeRepository>();
            services.AddScoped<IOrderDAL, OrderRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SEDC_WebAPI", Version = "v1" });
            });


            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SEDC2")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();
            
            app.UseCors();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SEDC_WebAPI v1"));

        }
    }
}
