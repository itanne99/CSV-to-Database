using System.ComponentModel.DataAnnotations;
using DB_Normalization.Enums;

namespace DB_Normalization.DataModels;

public class Songs
{
    [Key] public int Song_ID { get; set; }
    [Required] public string Song_Name { get; set; }
    [Required] public Genres Song_Genre { get; set; }
    [Required] public Albums Album_of_Song { get; set; }
    [Required] public Artists Song_Artist { get; set; }
}