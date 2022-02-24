using System.ComponentModel.DataAnnotations;
using DB_Normalization.Enums;

namespace DB_Normalization.DataModels;

public class Albums
{
    [Key] public int Album_ID { get; set; }
    [Required] public string Album_Name { get; set; }
    [Required] public int Release_Year { get; set; }
}