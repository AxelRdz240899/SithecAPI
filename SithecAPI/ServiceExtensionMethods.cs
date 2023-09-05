using Core.RepositoryInterfaces;
using Core.ServiceInterfaces;
using Infrastructure.EFRepository;
using Infrastructure.Services;

namespace SithecAPI
{
    public static class ServiceExtensionMethods
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IHumanRepository, HumanRepository>();
            services.AddScoped<IOperationService, OperationService>();
        }
    }
}
