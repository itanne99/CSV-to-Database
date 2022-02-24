using DB_Normalization.DataModels;
using DB_Normalization.Enums;

using var myContext = new Context();

var myClasses = myContext.Class.Where(c => c.MaxClassSize > 0)
    .ToList();
myContext.SaveChanges();

Console.Write("");
