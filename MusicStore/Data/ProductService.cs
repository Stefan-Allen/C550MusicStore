using System.Net;
using Microsoft.EntityFrameworkCore;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class ProductService
{
    // CRUD Action Read, Get All Products As A List
    public List<ProductSchema> GetProducts()
    {
        // New Database Instance
        var db = new Database();
        
        // Ensures the database is created
        db.Database.EnsureCreated();

        // Return the products with the Artist Schema Included as a List
        return db.Products.Include(e => e.Artist).ToList();
    }

    // CRUD Action Read Find a Product By Name, Is Nullable
    public ProductSchema? FindProduct(string query)
    {
        // New Database Instance
        var db = new Database();
        
        // Ensures the database is created
        db.Database.EnsureCreated();

        // Find the first product with the name or return a null value
       return db.Products.FirstOrDefault(
            p => p != null && p.Name.ToLower().Trim() == query.ToLower().Trim(), null);
    }

    // CRUD Action Read, Search the products by Name, Part of name and Artist
    public ProductSchema[] SearchProducts(string query)
    {
        // New Database Instance
        var db = new Database();

        // Ensure thge database is created
        db.Database.EnsureCreated();

        // Checks if the database has any products with that exact name
        if (db.Products.Include(p => p.Artist).Any(p => p.Name.ToLower().Trim() == query.ToLower().Trim()))
        {
            return db.Products.Include(p => p.Artist).ToArray();
        }

        // Checks if the database has any products with partial name matches
        var results = db.Products.Include(p => p.Artist).Where(p => p.Name.ToLower().Trim().Contains(query.ToLower().Trim())).ToArray();

        // Returns the results or Searches for products with a correct artist name if no matches returns an empty array 
        return results != Array.Empty<ProductSchema>() ? results : db.Products.Include(p => p.Artist).Where(p => p.Artist.Name.ToLower().Trim() == query.ToLower().Trim()).ToArray();
    }

    // CRUD Action Create, Adds a product to the database
    public HttpStatusCode AddProduct(string artistName, string name, string genre, string imageName, double price)
    {
        // New Database Instance
        var db = new Database();

        // Ensures the database is created
        db.Database.EnsureCreated();

        // Checks if a product is already in the database, if it is return conflict http status code
        if (db.Products.Any(
                p => p.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.Conflict;

        // Gets the artist from the database
        var artist = db.Artists.First(a => a.Name.ToLower().Trim() == artistName.ToLower().Trim());

        // Gets the Product Count
        var count = !db.Products.Any() ? 0 : db.Products.Max(x => x.Id);
        
        // Adds the Product To The Database
        db.Products.Add(new ProductSchema
        {
            Id = count + 1,
            Artist = artist,
            Name = name.Trim(),
            Genre = genre.Trim(),
            ImageName = imageName.Trim(),
            Price = price
        });

        // Saves The Database Changes
        db.SaveChanges();

        // Return Successfully Http Status code
        return HttpStatusCode.Created;
    }

    // CRUD Action Remove, Removes a product from the database
    public HttpStatusCode RemoveProduct(string name)
    {
        // New Database Instance
        var db = new Database();

        // Ensures that the database is created
        db.Database.EnsureCreated();

        // Checks if the product exist in the database if not return NotFound https staus code
        if (!db.Products.Any(
                p => p.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.NotFound;

        // Get the product from the database
        var product = db.Products.First(p => p.Name.ToLower().Trim() == name.ToLower().Trim());

        // Remove the product from the database
        db.Products.Remove(product);

        // Saves Database Changes
        db.SaveChanges();

        // Returns Successful Http Status Code
        return HttpStatusCode.Gone;
    }

    public ProductSchema[] SearchByGenre(string genre)
    {
        // New Database Instance
        var db = new Database();

        // Ensures The Database is created
        db.Database.EnsureCreated();

        // If no Products in that genre return empty Array
        if (!db.Products.Any(p => p.Genre.ToLower().Trim() == genre.Trim().ToLower()))
        {
            return Array.Empty<ProductSchema>();
        }

        // Returns all the products in that genre in an array
        return db.Products.Include(p => p.Artist).Where(p => p.Genre.ToLower().Trim() == genre.ToLower().Trim())
            .ToArray();
    }
}