using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.Bills.ValueObjects;

public sealed class BillId : ValueObject
{
    public Guid Value { get; }

    private BillId(Guid value) { Value = value; }

    public static BillId CreateUnique() { return new(Guid.NewGuid()); }

    public override IEnumerable<object> GetEqualityComponents() { yield return Value; }
}