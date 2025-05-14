using Microsoft.EntityFrameworkCore;

namespace UserManagementAPI.Data;

public class PersonContext : DbContext
{
    public DbSet <Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Host=localhost;Port=5241;Database=postgres;Username=postgres;Password=12231171";
        
        optionsBuilder.UseNpgsql(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}