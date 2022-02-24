using System.ComponentModel.DataAnnotations;
using DB_Normalization.Enums;

namespace DB_Normalization.DataModels;

public class Genres
{
    [Key]
    public int Genre_ID { get; set; }

    public string Genre_Name { get; set; }
}