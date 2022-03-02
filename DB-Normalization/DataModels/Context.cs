using Microsoft.EntityFrameworkCore;

namespace DB_Normalization.DataModels;

public class Context: DbContext
{
    public DbSet<Albums> Albums { get; set; }
    public DbSet<Artists> Artists { get; set; }
    public DbSet<Genres> Genres { get; set; }
    public DbSet<Songs> Songs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=music;Username=idoTanne;Password=password1234");;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genres>()
            .HasAlternateKey(c => c.Genre_Name);
    }
}