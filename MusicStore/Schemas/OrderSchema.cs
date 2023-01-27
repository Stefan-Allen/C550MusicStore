using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("ORDERS")]
public class OrderSchema
{
    // Primary Key For Schema
    public int Id { get; set; }
    // User who ordered Id
    public int UserId { get; set; }
    // Order Address
    public string Address { get; set; } = string.Empty;
    // What was ordered
    public string Contents { get; set; } = string.Empty;
    // Inputted Email
    public string Email { get; set; } = string.Empty;
}