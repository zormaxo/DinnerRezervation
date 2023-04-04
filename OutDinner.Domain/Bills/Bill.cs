using OutDinner.Domain.Bills.ValueObjects;
using OutDinner.Domain.Common.Models;
using OutDinner.Domain.Dinners.ValueObjects;
using OutDinner.Domain.Guests.ValueObjects;
using OutDinner.Domain.Hosts.ValueObjects;

namespace OutDinner.Domain.Bills;

public sealed class Bill : AggregateRoot<BillId>
{
    public DinnerId DinnerId { get; }

    public GuestId GuestId { get; }

    public HostId HostId { get; }

    public Price Price { get; }

    public DateTime CreatedDateTime { get; }

    public DateTime UpdatedDateTime { get; }

    private Bill(BillId id, GuestId guestId, HostId hostId, Price price, DateTime createdDateTime, DateTime updatedDateTime) : base(id)
    {
        GuestId = guestId;
        HostId = hostId;
        Price = price;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Bill Create(GuestId guestId, HostId hostId, Price price)
    {
        return new(
            BillId.CreateUnique(),
            guestId,
            hostId,
            price,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}