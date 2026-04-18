using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace Modul7_Ghinan
{
    internal class FilmFavorit_103022400017
    {
        public string title { get; set; }
        public string director { get; set; }

        public string year { get; set; }

        public string genre { get; set; }

        public double rating { get; set; }

        public int durationMinutes { get; set; }

        public bool isWatched { get; set; }
        public void ReadJSON() {
            string jsonString = File.ReadAllText("jurnal7_1_103022400017.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400017>(jsonString);

            Console.WriteLine($"Title: {data.title}");
            Console.WriteLine($"Director: {data.director}");
            Console.WriteLine($"Year: {data.year}");
            Console.WriteLine($"Genre: {data.genre}");
            Console.WriteLine($"rating: {data.rating}");
            Console.WriteLine($"Duration Minutes: {data.durationMinutes}");
            Console.WriteLine($"Is Watched: {data.isWatched}");
        }
    }
}
