using HelpNow.Called.Application.Services;
using HelpNow.Called.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace HelpNow.Called.Application.RegisterService;

public static class RegisterServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        
        services.AddScoped<ICalledService, CalledService>();

        return services;
    }
}
