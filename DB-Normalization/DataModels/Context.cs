using Microsoft.EntityFrameworkCore;

namespace DB_Normalization.DataModels;

public class Context: DbContext
{
    public DbSet<Class> Class { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=D:/College/Fourth Year - Semester Two/IS421/DB-Normalization/DB-Normalization/DB-Normalization/Classes.sqlite");
    }
}