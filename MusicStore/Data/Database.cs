using Microsoft.EntityFrameworkCore;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class Database : DbContext
{
    public DbSet<UserSchema> Users { get; set; }
    public DbSet<ProductSchema> Products { get; set; }
    public DbSet<ArtistSchema> Artists { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Environment.CurrentDirectory}/Database.sqlite");
    }
}