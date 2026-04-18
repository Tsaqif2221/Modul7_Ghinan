using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{
    internal class FilmFavorit_103022400038
    {
        public string title {  get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
        public double durationMinutes { get; set; }
        public bool isWatched { get; set; }

        public void ReadJSON()
        {
            string JsonString = File.ReadAllText("jurnal7_1_103022400038.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400038>(JsonString);
            Console.WriteLine($"title : {data.title}");
            Console.WriteLine($"director : {data.director}");
            Console.WriteLine($"year : {data.year}");
            Console.WriteLine($"genre : {data.genre}");
            Console.WriteLine($"rating : {data.rating}");
            Console.WriteLine($"durationMinutes : {data.durationMinutes}");
            Console.WriteLine($"isWatched : {data.isWatched}");

        }

    }

}
