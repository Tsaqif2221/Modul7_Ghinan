using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static Modul7_Ghinan.FilmFavorite;

namespace Modul7_Ghinan
{
    public class Watchlist
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }
    public class Watchlist_103022400007
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Watchlist> movies { get; set; }

        public void ReadJSON()
        {
            string filePath = "Jurnal7_2_103022400007.json";
            string jsonString = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<Watchlist_103022400007>(jsonString);
                Console.WriteLine($"Nama Watchlist: {data.watchlistName}");
                Console.WriteLine($"Dibuat oleh: {data.createdBy}");
                Console.WriteLine("Movies: ");
            foreach( var item in data.movies)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Title: {item.title}");
                Console.WriteLine($"Year: {item.year}");
                Console.WriteLine($"Genre: {item.genre}");
                Console.WriteLine($"Rating: {item.rating}");
                Console.WriteLine();
            }
        }
    }
}
