using OutDinner.Domain.Common.Models;
using OutDinner.Domain.Guests.ValueObjects;

namespace OutDinner.Domain.Guests;

public sealed class Guest : AggregateRoot<GuestId, Guid>
{
    public Guest(GuestId id) : base(id)
    {
    }
}