using System.Net;
using MusicStore.Schemas;

namespace MusicStore.Data;

public class ArtistService
{
    public HttpStatusCode AddArtist(string name)
    {
        var db = new Database();

        if (db.Artists.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.Conflict;

        db.Artists.Add(new ArtistSchema()
        {
            Id = db.Artists.Max(a => a.Id) + 1,
            ImageName = string.Empty,
            Name = name
        });

        db.SaveChanges();

        return HttpStatusCode.Created;
    }

    public HttpStatusCode RemoveArtist(string name)
    {
        var db = new Database();

        if (!db.Artists.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.NotFound;

        var artist = db.Artists.First(a => a.Name.ToLower().Trim() == name.ToLower().Trim());

        db.Artists.Remove(artist);

        db.SaveChanges();

        return HttpStatusCode.Gone;
    }
    
    public List<ArtistSchema> GetArtists()
    {
        var db = new Database();

        return db.Artists.ToList();
    }
}