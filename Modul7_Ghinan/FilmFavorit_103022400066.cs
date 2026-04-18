using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{
  
    public class FilmFavorit_103022400066
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022400066.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400066>(jsonString);
            Console.WriteLine($"Title : {data.title}");
            Console.WriteLine($"Director : {data.director}");
            Console.WriteLine($"Year : {data.year}");
            Console.WriteLine($"Genre : {data.genre}");
            Console.WriteLine($"Rating : {data.rating}");
            Console.WriteLine($"DurationMinutes : {data.durationMinutes}");
            Console.WriteLine($"isWatched : {data.isWatched}");
        }
    }

}
