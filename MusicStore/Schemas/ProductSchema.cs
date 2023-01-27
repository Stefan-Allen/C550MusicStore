using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("PRODUCTS")]
public class ProductSchema {
    // Primary Key For Schema
    public int Id { get; set; }
    // Artist Schema Gets Included Using EFCore
    [ForeignKey("ArtistId")]
    public virtual ArtistSchema Artist { get; set; }
    // Name of Product
    public string Name { get; set; } = string.Empty;
    // Genre of Product
    public string Genre { get; set; } = string.Empty;
    // Image of product (Not In Use ATM)
    public string ImageName { get; set; } = string.Empty;
    // Price of Product
    public double Price { get; set; } = 9.99;
}