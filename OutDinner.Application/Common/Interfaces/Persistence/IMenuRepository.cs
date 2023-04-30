using OutDinner.Domain.Menus;

namespace OutDinner.Application.Common.Interfaces.Persistence;

public interface IMenuRepository
{
    void Add(Menu menu);
}