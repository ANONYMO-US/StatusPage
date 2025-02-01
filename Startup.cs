using Microsoft.AspNetCore.Builder;
using FluentValidation;
using FluentValidation.AspNetCore;
using TaskmanagementApi.Serversidevalidation;
using TaskmanagementApi.ServiceLayer.IServices;
using TaskmanagementApi.ServiceLayer.Services;

namespace TaskmanagementApi
{
    public class Startup
    {
        private readonly string _policyName = "CorsPolicy";

        public static void ConfigureServices(IServiceCollection services) 
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy(name: "CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            services.AddMvc().AddFluentValidation();

            services.AddTransient<IValidator<DataLayer.Task>, TaskValidator>();
            services.AddScoped<ILoginService,LoginService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            app.UseCors(_policyName);
        }
    }
}
