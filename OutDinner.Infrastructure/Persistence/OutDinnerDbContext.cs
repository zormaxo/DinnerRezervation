using Microsoft.EntityFrameworkCore;
using OutDinner.Domain.Common.Models;
using OutDinner.Domain.Menus;
using OutDinner.Infrastructure.Persistence.Interceptors;

namespace OutDinner.Infrastructure.Persistence;

public class OutDinnerDbContext : DbContext
{
    private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;

    public OutDinnerDbContext(
        DbContextOptions<OutDinnerDbContext> options,
        PublishDomainEventsInterceptor publishDomainEventsInterceptor) : base(options)
    { _publishDomainEventsInterceptor = publishDomainEventsInterceptor; }

    public DbSet<Menu> Menus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<List<IDomainEvent>>().ApplyConfigurationsFromAssembly(typeof(OutDinnerDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
        base.OnConfiguring(optionsBuilder);
    }
}