using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.Dinners.ValueObjects;

public sealed class DinnerId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private DinnerId(Guid value) { Value = value; }

    public static DinnerId CreateUnique() { return new DinnerId(Guid.NewGuid()); }

    public override IEnumerable<object> GetEqualityComponents() { yield return Value; }

    private DinnerId()
    {
    }
}