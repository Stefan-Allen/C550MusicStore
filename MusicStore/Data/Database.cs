using Microsoft.EntityFrameworkCore;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class Database : DbContext
{
    // Holds all users
    public DbSet<UserSchema> Users { get; set; }
    // Holds all Products
    public DbSet<ProductSchema> Products { get; set; }
    // Holds all Artists
    public DbSet<ArtistSchema> Artists { get; set; }
    
    public DbSet<OrderSchema> Orders { get; set; }

    // Sets up configuration for using SQLite Database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Environment.CurrentDirectory}/Database.sqlite");
    }

    // Seeds The Database if it is empty with Products & Artists
    public static void TrySeedDatabase()
    {
        // New Database Instance
        var db = new Database();

        // Ensures that the Appropriate Tables Are Created
        db.Database.EnsureCreated();

        // If the database has artists return
        if (db.Artists.Any()) return;

        // Primary Key Values
        var artistCount = 1;
        var songCount = 1;

        // Artist Schema
        var annemarie = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Anne-Marie"
        };
        // Add Artist
        db.Artists.Add(annemarie);

        // Add Product
        db.Products.Add(new ProductSchema
        {
            Artist = annemarie,
            Genre = "Pop",
            Id = songCount,
            ImageName = string.Empty,
            Name = "FRIENDS",
            Price = 8.99
        });

        // Increase Counts
        artistCount++;
        songCount++;
        // This is repeating for each artist and song

        var edsheeran = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Ed Sheeran"
        };

        db.Artists.Add(edsheeran);
        
        db.Products.Add(new ProductSchema
        {
            Artist = edsheeran,
            Genre = "Pop",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Shape of You",
            Price = 6.99
        });

        artistCount++;
        songCount++;

        var miles = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Miles Davis"
        };

        db.Artists.Add(miles);
        
        db.Products.Add(new ProductSchema
        {
            Artist = miles,
            Genre = "Jazz",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Blue In Green",
            Price = 12.99
        });

        artistCount++;
        songCount++;

        var ella = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Ella Fitzgerald"
        };

        db.Artists.Add(ella);
        
        db.Products.Add(new ProductSchema
        {
            Artist = ella,
            Genre = "Jazz",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Ain't Misbehavin'",
            Price = 6.99
        });

        artistCount++;
        songCount++;

        var mingus = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Charles Mingus"
        };
        
        db.Artists.Add(mingus);
        
        db.Products.Add(new ProductSchema
        {
            Artist = mingus,
            Genre = "Jazz",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Song With Orange",
            Price = 8.99
        });

        artistCount++;
        songCount++;

        var monk = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Thelonious Monk"
        };
        
        db.Artists.Add(monk);

        db.Products.Add(new ProductSchema
        {
            Artist = monk,
            Genre = "Jazz",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Blue Monk",
            Price = 6.99
        });
        
        artistCount++;
        songCount++;

        var duke = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Duke Ellington"
        };
        
        db.Artists.Add(duke);
        
        db.Products.Add(new ProductSchema
        {
            Artist = duke,
            Genre = "Jazz",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Take The A Train",
            Price = 6.99
        });
        
        artistCount++;
        
        db.Artists.Add(new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Ornette Coleman"
        });
        
        artistCount++;
        songCount++;

        var beetles = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "The Beetles"
        };
        
        db.Artists.Add(beetles);
        db.Products.Add(new ProductSchema
        {
            Artist = beetles,
            Genre = "Rock",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Yesterday",
            Price = 15.99
        });
        
        
        artistCount++;
        songCount++;

        var eminem = new ArtistSchema
        {
            Id = artistCount,
            ImageName = string.Empty,
            Name = "Eminem"
        };
        
        db.Artists.Add(eminem);
        db.Products.Add(new ProductSchema
        {
            Artist =  eminem,
            Genre = "Rap",
            Id = songCount,
            ImageName = string.Empty,
            Name = "Till I Collapse",
            Price = 5.99
        });
        
        // Save Database Changes
        db.SaveChanges();
    }
}