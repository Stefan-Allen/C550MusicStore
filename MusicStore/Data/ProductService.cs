using System.Net;
using Microsoft.EntityFrameworkCore;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class ProductService
{
    public List<ProductSchema> GetProducts()
    {
        var db = new Database();

        db.Database.EnsureCreated();

        return db.Products.Include(e => e.Artist).ToList();
    }

    public ProductSchema? FindProduct(string query)
    {
        var db = new Database();

        db.Database.EnsureCreated();

       return db.Products.FirstOrDefault(
            p => p != null && p.Name.ToLower().Trim() == query.ToLower().Trim(), null);
    }

    public ProductSchema[] SearchProducts(string query)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (db.Products.Include(p => p.Artist).Any(p => p.Name.ToLower().Trim() == query.ToLower().Trim()))
        {
            return db.Products.Include(p => p.Artist).ToArray();
        }

        var results = db.Products.Include(p => p.Artist).Where(p => p.Name.ToLower().Trim().Contains(query.ToLower().Trim())).ToArray();

        return results != Array.Empty<ProductSchema>() ? results : db.Products.Include(p => p.Artist).Where(p => p.Artist.Name.ToLower().Trim() == query.ToLower().Trim()).ToArray();
    }

    public HttpStatusCode AddProduct(string artistName, string name, string genre, string imageName, double price)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (db.Products.Any(
                p => p.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.Conflict;

        var artist = db.Artists.First(a => a.Name.ToLower().Trim() == artistName.ToLower().Trim());

        var count = !db.Products.Any() ? 0 : db.Products.Max(x => x.Id);
        
        db.Products.Add(new ProductSchema
        {
            Id = count + 1,
            Artist = artist,
            Name = name.Trim(),
            Genre = genre.Trim(),
            ImageName = imageName.Trim(),
            Price = price
        });

        db.SaveChanges();

        return HttpStatusCode.Created;
    }

    public HttpStatusCode RemoveProduct(string name)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (!db.Products.Any(
                p => p.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.NotFound;

        var product = db.Products.First(p => p.Name.ToLower().Trim() == name.ToLower().Trim());

        db.Products.Remove(product);

        db.SaveChanges();

        return HttpStatusCode.Gone;
    }

    public ProductSchema[] SearchByGenre(string genre)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (!db.Products.Any(p => p.Genre.ToLower().Trim() == genre.Trim().ToLower()))
        {
            return Array.Empty<ProductSchema>();
        }

        return db.Products.Include(p => p.Artist).Where(p => p.Genre.ToLower().Trim() == genre.ToLower().Trim())
            .ToArray();
    }
}