

using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("Users")]
public class User
{
    public int UserId { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
    
    public DateTime DateCreated { get; set; }

    public int[] Songs { get; set; } = Array.Empty<int>();

    public int[] Playlists { get; set; } = Array.Empty<int>();

    public bool PremiumUser { get; set; } = false;
}