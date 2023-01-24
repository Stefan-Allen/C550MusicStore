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
            p => p != null && string.Equals(p.Name, query.Trim(), StringComparison.CurrentCultureIgnoreCase), null);
    }

    public ProductSchema[] SearchProducts(string query)
    {
        var db = new Database();

        db.Database.EnsureCreated();

        var results = db.Products.Where(p => string.Equals(p.Name.Trim(), query.Trim(), StringComparison.CurrentCultureIgnoreCase)).ToArray();

        return results != Array.Empty<ProductSchema>() ? results : db.Products.Where(p => String.Equals(p.Artist.Name.Trim(), query.Trim(), StringComparison.CurrentCultureIgnoreCase)).ToArray();
    }
}