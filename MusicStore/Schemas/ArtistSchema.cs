using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

public class ArtistSchema
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
}