using OutDinner.Domain.Common.Models;

namespace OutDinner.Domain.Menus.Events;

public record MenuCreated(Menu Menu) : IDomainEvent;
