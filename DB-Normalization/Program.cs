using DB_Normalization.DataModels;
using DB_Normalization.Utilites;


//Get File Path
Console.WriteLine("Please enter the absolute file path of the playlist:\r");
var filePath = Console.ReadLine();
var records = CsvRead.FromPath<CsvSong, CsvSongMap>(filePath);

using var myContext = new Context();
foreach (var record in records)
{
    
    if (!myContext.Songs.Any(s => s.Name == record.Name))//Checks if song name in db
    {
        Console.WriteLine($"Song Name: Adding {record.Name} to db");
        //Check if Album is in db
        //Check if Artist is in db
        var artist = new Artist();
        if (!myContext.Artists.Any(a => a.Name == record.Artist))
        {
            Console.WriteLine($"Artist Name: Adding {record.Artist} to db");
            artist = new Artist()
            {
                Name = record.Artist
            };
        }
        else
        {
            artist = myContext.Artists.First(a => a.Name == record.Artist);
        }
        
        var album = new Album();
        if (!myContext.Albums.Any(a => a.Name == record.Album))
        {
            Console.WriteLine($"Album Name: Adding {record.Album} to db");
            album = new Album()
            {
                Name = record.Album,
                Year = record.Year,
                Artist = artist
            };
        }
        else
        {
            album = myContext.Albums.First(a => a.Name == record.Album);
        }
        
        
        
        //Check if Genre is in db
        var genre = new Genre();
        if (!myContext.Genres.Any(g => g.Name == record.Genre))
        {
            Console.WriteLine($"Genre Name: Adding {record.Genre} to db");
            genre = new Genre()
            {
                Name = record.Genre
            };
        }
        else
        {
            genre = myContext.Genres.First(g => g.Name == record.Genre);
        }
        
        var song = new Song()
        {
            Album = album,
            Artist = artist,
            Genre = genre,
            Name = record.Name
        };
        
        myContext.Add(song);
        myContext.SaveChanges();
        
    }
    else
    {
        Console.WriteLine($"{record.Name} is already in db");
    }
    Console.WriteLine("-------------------------------------------");
}





/* OLD EXAMPLE
 
 using var myContext = new Context();
myContext.Add(new Songs()
{
    Album_of_Song = new Albums()
    {
        Album_Name = "Black Parade",
        Release_Year = 2001
    },
    Song_Artist = new Artists()
    {
        Artist_Name = "MCR"
    },
    Song_Genre = new Genres()
    {
        Genre_Name = "Punk"
    },
    Song_Name = "welcome to the black parade"
});
myContext.SaveChanges();*/
