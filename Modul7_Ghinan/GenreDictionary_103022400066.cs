using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Ghinan
{

    public genreRoot GenreDictionary { get; set; }
   
    public class movies
    {
        public string popularMovies { get; set; }

    }

    public class genreRoot
    {
        public string category {  get; set; }
        public string genreDictionary_103022400066 {  get; set; }
    }
    public class GenreDictionary_103022400066
    {
        public string category {  get; set; }
        public string id {  get; set; }
        public string name {  get; set; }
        public string description {  get; set; }
        public List<movies> popularMovies { get; set; }

        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103022400066");
            var data = JsonSerializer.Deserialize<GenreDictionary_103022400066>(jsonString);

            GenreDictionary_103022400066 info = data.GenreDictionary
            Console.WriteLine($"Category :  {data.category}");
            Console.WriteLine($"ID :  {data.id}");
            Console.WriteLine($"Name :  {data.name}");
            Console.WriteLine($"Description :  {data.description}");
            Console.WriteLine("Popular Movies :");
            foreach(var item in data.popularMovies)
            {
                Console.WriteLine($"ID : {item.popularMovies}");
            }

    }
