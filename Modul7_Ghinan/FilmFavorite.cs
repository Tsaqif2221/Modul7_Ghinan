using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{

    public class FilmFavorite
    {
       public class FilmFavorite_103022400007
        {
            public string title { get; set; }
            public string director { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "Jurnal7_1_103022400007.json";
            string jsonString = File.ReadAllText(filePath);
            FilmFavorite_103022400007? data = JsonSerializer.Deserialize<FilmFavorite_103022400007>(jsonString);
            
            if (data != null)
            {
                Console.WriteLine($"Title: {data.title}");
                Console.WriteLine($"Director: {data.director}");
                Console.WriteLine($"Year: {data.year}");
                Console.WriteLine($"Genre: {data.genre}");
                Console.WriteLine($"Rating: {data.rating}");
                Console.WriteLine($"Menit Durasi: {data.durationMinutes}");
                Console.WriteLine($"Udah ditonton? {data.isWatched}");
            }
        }
    }
}
