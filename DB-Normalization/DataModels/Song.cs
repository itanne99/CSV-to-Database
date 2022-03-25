﻿namespace DB_Normalization.DataModels
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Artist Artist { get; set; }
        
        public Album Album { get; set; }

        public Genre Genre { get; set; }
    }
}