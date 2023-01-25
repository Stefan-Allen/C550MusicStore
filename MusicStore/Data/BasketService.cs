using MusicStore.Schemas;

namespace MusicStore.Data;

public class BasketService
{
    public readonly Dictionary<ProductSchema, int> Products = new();

    public void AddProduct(ProductSchema item)
    {
        if (Products.ContainsKey(item))
        {
            Products.Add(item, 1);
            return;
        }

        var count = Products[item];
        count++;
        Products.Remove(item);
        Products.Add(item, count);
    }

    public void RemoveProduct(ProductSchema item)
    {
        if (!Products.ContainsKey(item))
        {
            return;
        }

        Products.Remove(item);
    }

    public void DecreaseProduct(ProductSchema item)
    {
        if (!Products.ContainsKey(item))
        {
            return;
        }
        
        var count = Products[item];

        if (count == 1)
        {
            RemoveProduct(item);
            return;
        }
        
        count--;
        Products.Remove(item);
        Products.Add(item, count);
    }

    public Double GetTotal()
    {
        var total = 0.0;
        foreach (var keyValuePair in Products)
        {
            var subcost = keyValuePair.Key.Price * keyValuePair.Value;

            total = +subcost;
        }

        return total;
    }
}