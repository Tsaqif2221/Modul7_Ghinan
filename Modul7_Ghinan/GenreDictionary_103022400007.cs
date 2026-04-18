using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{
    public class movies
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string popularMovie { get; set; }
    }
    public class GenreDictionary_103022400007
    {
        public string category { get; set; }
        public List<movies> popularMovies { get; set; }

        public void ReadJSON()
        {
            string filePath = "Jurnal7_3_103022400007.json";
            string jsonString = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<GenreDictionary_103022400007>(jsonString);
            Console.WriteLine($"Category: {data.category}");
            foreach (var item in data.popularMovies)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Nama: {item.name}");
                Console.WriteLine($"Deskripsi: {item.desc}");
                Console.WriteLine($"Popular Movies: {item.popularMovie}");
                Console.WriteLine();
            }
        }
    }
}
