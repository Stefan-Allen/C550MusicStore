namespace MusicStore.Schemas;

public class Playlist
{
    public int PlaylistId { get; set; }
    
    public int OwnerId { get; set; } = -1;

    public string Name { get; set; } = string.Empty;
    
    public string[] Genres { get; set; } = Array.Empty<string>();

    public int[] Songs { get; set; } = Array.Empty<int>();

    public int[] Viewers { get; set; } = Array.Empty<int>();
    
    public DateTime DateCreated { get; set; }
}