﻿using System.Collections.Generic;

namespace DB_Normalization.DataModels
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        /*public ICollection<Song> Songs { get; set; }
        
        public ICollection<Album> Albums { get; set; }*/
    }
}