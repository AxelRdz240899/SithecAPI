using Core.RepositoryInterfaces;
using Infrastructure.EFRepository;

namespace SithecAPI
{
    public static class ServiceExtensionMethods
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IHumanRepository, HumanRepository>();
        }
    }
}
