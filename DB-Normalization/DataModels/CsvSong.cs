using CsvHelper.Configuration;
using DB_Normalization.Utilites;

namespace DB_Normalization.DataModels;

public class CsvSong
{
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
}

public class CsvSongMap : ClassMap<CsvSong>
{
        public CsvSongMap()
        {
                Map(m => m.Name);
                Map(m => m.Artist);
                Map(m => m.Album);
                Map(m => m.Genre);
                Map(m => m.Year).TypeConverter<CustomIntConverter>();
        }
}