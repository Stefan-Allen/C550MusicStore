using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

public class ArtistSchema
{
    // Primary Key for Schema
    public int Id { get; set; }
    // Name of Artist
    public string Name { get; set; } = string.Empty;
    // Image Name (Not In Use At The Moment)
    public string ImageName { get; set; } = string.Empty;
}