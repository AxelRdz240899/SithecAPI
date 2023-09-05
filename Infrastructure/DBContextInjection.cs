using Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public static class DBContextInjection
    {
        public static IServiceCollection InjectDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                string ConnectionString = configuration["ConnectionStrings:Default"] ?? string.Empty;
                options.UseSqlServer(ConnectionString);
            });

            return services;
        }
    }
}
