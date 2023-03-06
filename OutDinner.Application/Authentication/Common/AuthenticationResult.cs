using OutDinner.Domain.Entities;

namespace OutDinner.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);