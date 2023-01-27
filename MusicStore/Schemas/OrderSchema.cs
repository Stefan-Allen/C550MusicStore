using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("ORDERS")]
public class OrderSchema
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Contents { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}