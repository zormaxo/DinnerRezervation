using Microsoft.AspNetCore.Mvc.Infrastructure;
using OutDinner.Api.Common.Errors;
using OutDinner.Api.Common.Mapping;

namespace OutDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, OutDinnerProblemDetailsFactory>();
        services.AddMappings();
        return services;

        //services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    }
}