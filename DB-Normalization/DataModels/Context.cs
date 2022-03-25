using Microsoft.EntityFrameworkCore;

namespace DB_Normalization.DataModels;

public class Context: DbContext
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Database=graphQL; Username=JimmyCricket; Password=AppleBombs4152");;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
            
        modelBuilder.Entity<Genre>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
            
        modelBuilder.Entity<Artist>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
            
        modelBuilder.Entity<Song>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
    }

    
}