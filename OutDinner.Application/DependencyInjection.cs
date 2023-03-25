using ErrorOr;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OutDinner.Application.Authentication.Commands.Register;
using OutDinner.Application.Authentication.Common;
using OutDinner.Application.Common.Behaviors;
using System.Reflection;

namespace OutDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
        //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidateRegisterCommandBehavior));
        services.AddScoped<IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>, ValidateRegisterCommandBehavior>();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
