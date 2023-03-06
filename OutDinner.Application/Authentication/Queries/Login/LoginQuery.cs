using ErrorOr;
using MediatR;
using OutDinner.Application.Authentication.Common;

namespace OutDinner.Application.Authentication.Queries.Login;

public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;