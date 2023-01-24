using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("PRODUCTS")]
public class ProductSchema {
    public int Id { get; set; }
    [ForeignKey("ArtistId")]
    public virtual ArtistSchema Artist { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public double Price { get; set; } = 9.99;
}