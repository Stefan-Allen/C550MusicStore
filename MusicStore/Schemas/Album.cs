namespace MusicStore.Schemas;

public class Album
{
    public int AlbumId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int[] Artists { get; set; } = Array.Empty<int>();

    public int[] Songs { get; set; } = Array.Empty<int>();

    public string Genre { get; set; } = string.Empty;
    
    public DateTime ReleasedDate { get; set; }
}