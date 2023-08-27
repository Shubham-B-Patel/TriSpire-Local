using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Solution.Core.Common.Interfaces;
using Solution.Core.Interfaces.Common;
using Solution.Core.Interfaces.Dapper;
using Solution.Infrastructure.Dapper;
using Solution.Infrastructure.Implementation.Services;
using Solution.Infrastructure.Persistence;

namespace Solution.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"),
                    builder =>
                    {
                        builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                    });
            });

            /*services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddSingleton<IDapperContext, DapperContext>();*/
            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>());
            services.AddSingleton<IDapperContext, DapperContext>();

            services.AddTransient<IAgencySupportTicketService, AgencySupportTicketService>();

            return services;
        }
    }
}
