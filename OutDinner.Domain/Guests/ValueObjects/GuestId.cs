using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.Guests.ValueObjects;

public sealed class GuestId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private GuestId(Guid value) { Value = value; }

    public static GuestId CreateUnique() { return new(Guid.NewGuid()); }

    public override IEnumerable<object> GetEqualityComponents() { yield return Value; }
}