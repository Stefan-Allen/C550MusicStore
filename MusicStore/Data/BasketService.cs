using System.Net;
using MusicStore.Schemas;

namespace MusicStore.Data;

// Service for handing the Basket
public class BasketService
{
    // Stores Products Using a ProductSchema as Key then the Value is the Quantity
    public readonly Dictionary<ProductSchema, int> Products = new();

    // Add Product to Dictionary / Basket
    public void AddProduct(ProductSchema item)
    {
        // Check if product is not in Basket if not add it
        if (!Products.ContainsKey(item))
        {
            Products.Add(item, 1);
            return;
        }

        // Increases Quantity in Basket By One
        var count = Products[item];
        count++;
        Products.Remove(item);
        Products.Add(item, count);
    }

    // Removes a Product From The Basket
    public void RemoveProduct(ProductSchema item)
    {
        // Check if the product is not in the basket if not just returns
        if (!Products.ContainsKey(item))
        {
            return;
        }

        // Removes The Product
        Products.Remove(item);
    }

    // Decrease The Quantity of a Product In The Basket
    public void DecreaseProduct(ProductSchema item)
    {
        // Checks if the product is in the basket if not returns
        if (!Products.ContainsKey(item))
        {
            return;
        }
        
        // Gets Amount of Product in Basket
        var count = Products[item];

        // If only one product removes the product from the basket then returns
        if (count == 1)
        {
            RemoveProduct(item);
            return;
        }
        
        // Decreases Product Quatity in Basket By One
        count--;
        Products.Remove(item);
        Products.Add(item, count);
    }

    // Gets Total Cost of the Basket
    public Double GetTotal()
    {
        // To Store Total Cost
        var total = 0.0;
        
        // Goes through each product multiplying the price by quantity the adding to total
        foreach (var keyValuePair in Products)
        {
            var subcost = keyValuePair.Key.Price * keyValuePair.Value;

            total += subcost;
        }
        // returns the total
        return total;
    }

    // CRUD Action Create Orders, and Puts the in the Orders Table
    public HttpStatusCode Checkout(string email, string address, UserSchema user)
    {
        // Check Basket is not empty
        if (Products.Count == 0) return HttpStatusCode.NotFound;
        
        // New Database Instance
        var db = new Database();

        // Ensures the database is created
        db.Database.EnsureCreated();
        
        // Check the Order Count
        var count = !db.Orders.Any() ? 0 : db.Orders.Max(x => x.Id);

        // Initialise Contents String
        var contents = "";
        
        // Add Each Product to The Contents String
        foreach (var (key, value) in Products)
        {
            contents += $"------------\nID:{key.Id}\nName:{key.Name}\nArtist: {key.Artist.Name}\nPrice: {key.Price}\nQuantity: {value}\n";
        }

        // Add Ending String
        contents += "------------";
        
        // Add Order To Database
        db.Orders.Add(new OrderSchema
        {
            Id = count + 1,
            UserId = user.Id,
            Address = address,
            Contents = contents,
            Email = email
        });

        // Save Changes To Database
        db.SaveChanges();
        
        // Clear Basket
        Products.Clear();
        
        // Respond With Success Http Status Code
        return HttpStatusCode.Created;
    }
}