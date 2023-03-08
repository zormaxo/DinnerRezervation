using Microsoft.AspNetCore.Mvc.Infrastructure;
using OutDinner.Api;
using OutDinner.Api.Common.Errors;
using OutDinner.Application;
using OutDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPresentation().AddApplication().AddInfrastructure(builder.Configuration);

var app = builder.Build();
//app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();