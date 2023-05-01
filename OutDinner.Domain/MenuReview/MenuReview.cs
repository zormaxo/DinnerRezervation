using OutDinner.Domain.Common.Models;
using OutDinner.Domain.Common.ValueObjects;
using OutDinner.Domain.Dinners.ValueObjects;
using OutDinner.Domain.Guests.ValueObjects;
using OutDinner.Domain.Hosts.ValueObjects;
using OutDinner.Domain.MenuReview.ValueObjects;
using OutDinner.Domain.Menus.ValueObjects;

namespace OutDinner.Domain.MenuReview;

public sealed class MenuReview : AggregateRoot<MenuReviewId, Guid>
{
    public Rating Rating { get; }

    public string Comment { get; }

    public HostId HostId { get; }

    public MenuId MenuId { get; }

    public GuestId GuestId { get; }

    public DinnerId DinnerId { get; }

    public DateTime CreatedDateTime { get; }

    public DateTime UpdatedDateTime { get; }

    private MenuReview(
        MenuReviewId menuReviewId,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        DinnerId dinnerId,
        DateTime createdDateTime,
        DateTime updatedDateTime) : base(menuReviewId)
    {
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        DinnerId = dinnerId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static MenuReview Create(string comment, HostId hostId, MenuId menuId, GuestId guestId, DinnerId dinnerId)
    {
        return new(
            MenuReviewId.CreateUnique(),
            comment,
            hostId,
            menuId,
            guestId,
            dinnerId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}