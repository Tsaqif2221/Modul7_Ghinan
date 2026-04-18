using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{
    public class Watchlist
    {
        public string id {  get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }

    }

    public class Watchlist_103022400066
    {
        public string watchListName {  get; set; }

        public string createdby { get; set; }

        public List<Watchlist> movies { get; set; } 

        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400066.json");
            var data = JsonSerializer.Deserialize<Watchlist_103022400066>(jsonString);
            Console.WriteLine($"Watch List Name : {data.watchListName}");
            Console.WriteLine($"Created By : {data.createdby}");
            Console.WriteLine($"Movies List : ");
            foreach (var item in data.movies)
            {
                Console.WriteLine($"ID : {item.id}");
                Console.WriteLine($"Title : {item.title}");
                Console.WriteLine($"Year : {item.year}");
                Console.WriteLine($"Genre : {item.genre}");
                Console.WriteLine($"Rating : {item.rating}");
                Console.WriteLine();
            }

        }
    }
}
