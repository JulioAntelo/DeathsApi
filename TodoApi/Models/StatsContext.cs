using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class StatsContext : DbContext
{
    public StatsContext(DbContextOptions<StatsContext> options)
        : base(options)
    {
    }

    public DbSet<Stats> TodoItems { get; set; } = null!;
}