using System.ComponentModel.DataAnnotations;
using DB_Normalization.Enums;

namespace DB_Normalization.DataModels;

public class Artists
{
    [Key]
    public int Artist_ID { get; set; }

    [Required]
    public string Artist_Name { get; set; }
}