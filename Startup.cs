using CarsAPI.DAL;
using CarsAPI.Middlewares;
using CarsAPI.Services;
using Microsoft.EntityFrameworkCore;

using Microsoft.OpenApi.Models;
using CarsAPI.Features;

namespace CarsAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(o => o.UseInMemoryDatabase(databaseName:"Test"));
            services.AddTransient<IEmailSender, FakeEmailSender>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo() 
                {
                    Version = "v1", 
                    Title = "Test API",
                    Description = "ASP.NET Core API",
                });
                c.OperationFilter<SwaggerHeaderParameter>();
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });

            app.UseMiddleware<AuthenticationMiddleware>();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "cars",
                pattern: "{controller=Cars}/{action=Get}/{page?}");
            });
        }
    }
}
