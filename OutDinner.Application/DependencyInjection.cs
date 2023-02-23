using Microsoft.Extensions.DependencyInjection;
using OutDinner.Application.Services.Authentication;

namespace OutDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
