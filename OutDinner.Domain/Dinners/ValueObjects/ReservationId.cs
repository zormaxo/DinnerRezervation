using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.Dinners.ValueObjects;

public sealed class ReservationId : ValueObject
{
    public Guid Value { get; }

    private ReservationId(Guid value) { Value = value; }

    public static ReservationId CreateUnique() { return new(Guid.NewGuid()); }

    public override IEnumerable<object> GetEqualityComponents() { yield return Value; }
}