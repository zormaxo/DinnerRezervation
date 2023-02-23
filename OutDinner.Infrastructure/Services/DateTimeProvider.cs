using OutDinner.Application.Common.Interfaces.Services;

namespace OutDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
