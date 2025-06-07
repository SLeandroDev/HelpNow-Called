using HelpNow.Called.Domain.Interfaces;
using HelpNow.Called.Infrastructure.Repository;
using HelpNow.Called.Infrastructure.UoW;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace HelpNow.Called.Infrastructure.RegisterRepository;

public static class RegisterRepository
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        // Registra a connection string como IDbConnection Scoped
        services.AddScoped<IDbConnection>(sp =>
        {
            var connString = configuration.GetConnectionString("DefaultConnection");
            return new SqlConnection(connString);
        });

        // Registra os repositórios
        services.AddScoped<ICalledRepository, CalledRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();


        return services;
    }
}
