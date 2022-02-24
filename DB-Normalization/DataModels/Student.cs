using System.ComponentModel.DataAnnotations;

namespace DB_Normalization.DataModels;

public class Student
{
    [Key]
    public int Student_ID { get; set; }
    
    
    public string StudentName { get; set; }

    public int Age { get; set; }

    public List<Class> Student_Classes { get; set; }
}