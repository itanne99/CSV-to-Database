using System.ComponentModel.DataAnnotations;

namespace DB_Normalization.DataModels;

public class Songs
{
    [Key] public int ID { get; set; }
    public string Song_Name { get; set; }
    public Genres Song_Genre { get; set; }
    public Albums Album_of_Song { get; set; }
    public Artists Song_Artist { get; set; }
}