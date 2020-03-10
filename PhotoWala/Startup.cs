using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhotoWala.BLL;
using PhotoWala.DatabaseContext.DatabaseContext;
using PhotoWala.Interface;
using PhotoWala.Interface.IService;
using PhotoWala.Models;
using PhotoWala.Service;
using PhotoWala.Service.Repositories;

namespace PhotoWala
{
    public class Startup
    {
        //
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<PhotoWalaDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultDBConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGenericService<User>, GenericService<User>>();
            services.AddTransient<IGenericService<Test>, GenericService<Test>>();
            services.AddScoped<IUserRepository, UserRepository>();
            //
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //
            app.UseHttpsRedirection();

            app.UseRouting();
            //
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(" Only for API");
                });
            });
        }
    }
}
