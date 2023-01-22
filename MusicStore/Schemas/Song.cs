namespace MusicStore.Schemas;

public class Song
{
    public int SongId { get; set; }
    
    public string Name { get; set; }

    public int[] Artists { get; set; } = Array.Empty<int>();

    public string Genre { get; set; } = string.Empty;
    
    public DateTime ReleasedDate { get; set; }
}