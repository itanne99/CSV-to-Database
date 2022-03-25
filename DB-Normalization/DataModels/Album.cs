using System.Collections.Generic;

namespace DB_Normalization.DataModels
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        /*public Artist Aritst { get; set; }
        public ICollection<Song> Songs { get; set; }*/
        
    }
}