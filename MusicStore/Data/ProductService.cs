using System.Net;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class ProductService
{
    public ProductSchema[] GetProducts()
    {
        var db = new Database();

        db.Database.EnsureCreated();

        return db.Products.ToArray();
    }

    public List<ArtistSchema> GetArtists()
    {
        var db = new Database();

        return db.Artists.ToList();
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

        var results = db.Products.Where(p => p.Name.ToLower().Trim().Contains(query.ToLower().Trim())).ToArray();

        return results != Array.Empty<ProductSchema>() ? results : db.Products.Where(p => p.Artist.Name.ToLower().Trim() == query.ToLower().Trim()).ToArray();
    }

    public HttpStatusCode AddProduct(string artistName, string name, string genre, string imageName, double price)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (db.Products.Any(
                p => p.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.Conflict;

        var artist = db.Artists.First(a => a.Name.ToLower().Trim() == artistName.ToLower().Trim());

        db.Products.Add(new ProductSchema
        {
            Id = db.Products.Max(x => x.Id) + 1,
            Artist = artist,
            Name = name,
            Genre = genre,
            ImageName = imageName,
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
}