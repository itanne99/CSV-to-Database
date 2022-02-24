using System.ComponentModel.DataAnnotations;
using DB_Normalization.Enums;

namespace DB_Normalization.DataModels;

public class Class
{
    public int ClassID { get; set; }
    
    [MaxLength(50)]
    public string ClassName { get; set; }
    
    public int MaxClassSize     { get; set; }
    public Language ClassLanguage { get; set; }
}