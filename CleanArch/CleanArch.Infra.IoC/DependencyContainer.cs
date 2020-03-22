using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Aplication Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Lyer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
