using Core.RepositoryInterfaces;
using Core.ServiceInterfaces;
using Infrastructure.EFRepository;
using Infrastructure.Services;
using SithecAPI.Middleware;

namespace SithecAPI
{
    public static class ServiceExtensionMethods
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<ErrorHandlerMiddleware>();
            services.AddScoped<IHumanRepository, HumanRepository>();
            services.AddScoped<IOperationService, OperationService>();
        }
    }
}
