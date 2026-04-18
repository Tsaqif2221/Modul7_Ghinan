using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

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
    internal class Watchlist_103022400017
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<Watchlist> movies { get; set; }



        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400017.json");
            var data = JsonSerializer.Deserialize<Watchlist_103022400017>(jsonString);

            Console.WriteLine($"Nama Watchlist: {data.watchlistName}");
            Console.WriteLine($"nama Watchlist: {data.createdBy}");

            foreach (var item in data.movies)
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
