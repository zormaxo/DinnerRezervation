using OutDinner.Domain.Entities;

namespace OutDinner.Application.Services.Authentication;

public record AuthenticationResult(User User, string Token);