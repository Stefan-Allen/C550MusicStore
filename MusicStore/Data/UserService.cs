using System.Net;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class UserService
{
    public UserSchema? User;

    public async Task<HttpStatusCode> LoginAsync(string username, string password)
    {
        var db = new Database();
        await db.Database.EnsureCreatedAsync();

        var user = db.Users.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim());

        if (user == null)
        {
            return HttpStatusCode.NotFound;
        }
        if (!VerifyPassword(password, user.Password, user.Salt))
        {
            return HttpStatusCode.Forbidden;
        }

        User = user;

        return HttpStatusCode.Accepted;
    }

    public async Task<HttpStatusCode> RegisterAsync(string username, string password, string fullName, DateTime dob, string gender, string title)
    {
        var db = new Database();
        await db.Database.EnsureCreatedAsync();
        
        if (db.Users.Any(x => x.Username.Trim().ToLower() == username.Trim().ToLower()))
        {
            return HttpStatusCode.Conflict;
        }

        var hashed = HashPasword(password, out var salt);

        var user = new UserSchema
        {
            Created = DateTime.Now,
            Id = db.Users.Count() + 1,
            Dob = dob,
            Username = username.Trim(),
            FullName = fullName,
            Password = hashed,
            Salt = salt,
            Gender = gender
        };

        db.Users.Add(user);

        await db.SaveChangesAsync();

        return HttpStatusCode.Created;
    }
    
    private string HashPasword(string password, out string salt)
    {
        salt = GetSalt();
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            Encoding.UTF8.GetBytes(salt),
            350000,
            HashAlgorithmName.SHA512,
            64);
        return Convert.ToHexString(hash);
    }
    
    private bool VerifyPassword(string password, string hash, string salt)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(salt), 350000, HashAlgorithmName.SHA512, 64);
        return hashToCompare.SequenceEqual(Convert.FromHexString(hash));
    }
    
    
    private static string GetSalt()  
    {  
        var bytes = new byte[128 / 8];
        using var keyGenerator = RandomNumberGenerator.Create();
        keyGenerator.GetBytes(bytes);  
        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
    }

    public List<OrderSchema> GetOrders()
    {
        var db = new Database();

        db.Database.EnsureCreated();

        if (!db.Orders.Any() || !db.Orders.Any(p => p.UserId == this.User!.Id)) return new List<OrderSchema>();

        return db.Orders.Where(o => o.UserId == this.User!.Id).ToList();
    }

}
