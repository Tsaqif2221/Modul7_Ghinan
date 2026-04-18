using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{
    public class watchlist
    {
        public string id {  get; set; }
        public string title {  get; set; }
        public int year {  get; set; }
        public string genre {  get; set; }
        public double rating {  get; set; }
    }
    public class Watchlist_103022430004
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<watchlist> movies { get; set; }
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022430004.json");
            var data = JsonSerializer.Deserialize<Watchlist_103022430004>(jsonString);
            Console.WriteLine($"Watch List Name : {data.watchlistName}");
            Console.WriteLine($"Created by : {data.createdBy}");
            Console.WriteLine("Movies list: ");
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
