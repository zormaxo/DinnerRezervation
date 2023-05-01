using OutDinner.Application.Common.Interfaces.Persistence;
using OutDinner.Domain.Menus;

namespace OutDinner.Infrastructure.Persistence.Repositories;

public sealed class MenuRepository : IMenuRepository
{
    private readonly OutDinnerDbContext _dbContext;

    public MenuRepository(OutDinnerDbContext dbContext) { _dbContext = dbContext; }

    public void Add(Menu menu)
    {
        _dbContext.Add(menu);
        _dbContext.SaveChanges();
    }
}