using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OutDinner.Application.Common.Interfaces.Authentication;
using OutDinner.Application.Common.Interfaces.Persistence;
using OutDinner.Application.Common.Interfaces.Services;
using OutDinner.Infrastructure.Authentication;
using OutDinner.Infrastructure.Persistence;
using OutDinner.Infrastructure.Services;

namespace OutDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
