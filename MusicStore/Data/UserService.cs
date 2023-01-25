using System.Net;
using System.Security.Cryptography;
using System.Text;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class UserService
{
    public UserSchema? User;
    
    public async Task<HttpStatusCode> LoginAsync(string username, string password)
    {
        var db = new Database();
        await db.Database.EnsureCreatedAsync();

        var user = db.Users.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase), null);

        if (user == null)
        {
            return HttpStatusCode.NotFound;
        }

        if (!VerifyPassword(password, user.Password, Encoding.UTF8.GetBytes(user.Salt)))
        {
            return HttpStatusCode.Forbidden;
        }

        User = user;

        return HttpStatusCode.Accepted;
    }

    public async Task<HttpStatusCode> RegisterAsync(string username, string password, string fullName, DateTime dob, string gender, string title)
    {
        Console.WriteLine(dob);
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
            Salt = Encoding.UTF8.GetString(salt),
            Gender = gender
        };

        db.Users.Add(user);

        await db.SaveChangesAsync();

        return HttpStatusCode.Created;
    }
    
    private string HashPasword(string password, out byte[] salt)
    {
        salt = RandomNumberGenerator.GetBytes(64);
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            350000,
            HashAlgorithmName.SHA512,
            64);
        return Convert.ToHexString(hash);
    }
    
    private bool VerifyPassword(string password, string hash, byte[] salt)
    {
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, 35000, HashAlgorithmName.SHA512, 64);
        return hashToCompare.SequenceEqual(Convert.FromHexString(hash));
    }
}