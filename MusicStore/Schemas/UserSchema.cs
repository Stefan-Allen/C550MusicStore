using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Schemas;

[Table("USERS")]
public class UserSchema
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateTime Dob { get; set; } = DateTime.MinValue;
    public DateTime Created { get; set; } = DateTime.MinValue;

    [ForeignKey("OrderId")]
    public virtual List<OrderSchema> Orders { get; set; } = new();
}