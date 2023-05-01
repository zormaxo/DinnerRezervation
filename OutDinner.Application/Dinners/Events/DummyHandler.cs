using MediatR;
using OutDinner.Domain.Menus.Events;

namespace OutDinner.Application.Dinners.Events;
public class DummyHandler : INotificationHandler<MenuCreated>
{
    public Task Handle(MenuCreated notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
