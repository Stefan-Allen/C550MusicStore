using System.Net;
using MusicStore.Schemas;

namespace MusicStore.Data;

// Service for Interacting with ArtistSchema
public class ArtistService
{
    
    // CRUD Create Action to Add An Artist
    public HttpStatusCode AddArtist(string name)
    {
        // Makes Database Instance
        var db = new Database();

        // Checks if an artist with that name already exists
        if (db.Artists.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.Conflict;
        
        // Gets the max id number in the db so that it can add one for the primary key
        var count = !db.Artists.Any() ? 0 : db.Artists.Max(a => a.Id);
        
        // Adds the artist
        db.Artists.Add(new ArtistSchema
        {
            Id =  count + 1,
            ImageName = string.Empty,
            Name = name
        });

        // Saves Database Changes
        db.SaveChanges();
        
        // Returns the Http Status Code Created Showing the Artist was Successfully Created
        return HttpStatusCode.Created;
    }

    // CRUD Delete Action to Remove a Artist
    public HttpStatusCode RemoveArtist(string name)
    {
        // Makes Database Instance
        var db = new Database();

        // Checks if the artist exists if not return a NotFound Code
        if (!db.Artists.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim())) return HttpStatusCode.NotFound;

        // Gets the artist from the database
        var artist = db.Artists.First(a => a.Name.ToLower().Trim() == name.ToLower().Trim());

        // Removes The Artist
        db.Artists.Remove(artist);

        // Saves the database changes
        db.SaveChanges();

        // Returns the http status code Gone to show success
        return HttpStatusCode.Gone;
    }
    
    // CRUD Read Action
    public List<ArtistSchema> GetArtists()
    {
        // New Database Instance
        var db = new Database();

        // Return all artist in a list
        return db.Artists.ToList();
    }
}