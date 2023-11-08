using Domain.Interfaces;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Inyección de dependencias de servicios personalizados
            services.AddScoped<IItemRepository, ItemRepository>();

            // Entity Framework
            var connectionString = $"Server={configuration.GetConnectionString("DefaultConnection:HostName")};" +
                                            $"Database={configuration.GetConnectionString("DefaultConnection:Catalogue")};" +
                                            $"User ID={configuration.GetConnectionString("DefaultConnection:User")};" +
                                            $"Password={configuration.GetConnectionString("DefaultConnection:Password")};" +
                                            $"Encrypt=False;MultipleActiveResultSets=True;";
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}