using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.MenuReview.ValueObjects;

public sealed class MenuReviewId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private MenuReviewId(Guid value) { Value = value; }

    public static MenuReviewId CreateUnique() { return new MenuReviewId(Guid.NewGuid()); }

    public override IEnumerable<object> GetEqualityComponents() { yield return Value; }

    private MenuReviewId()
    {
    }
}