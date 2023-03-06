using ErrorOr;
using MediatR;
using OutDinner.Application.Authentication.Common;

namespace OutDinner.Application.Authentication.Commands.Register;

public record RegisterCommand(string FirstName, string LastName, string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;