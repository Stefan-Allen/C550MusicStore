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
}