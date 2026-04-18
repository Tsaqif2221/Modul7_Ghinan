using Modul7_Ghinan;
using System;

class Program
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400066 Favfilm = new FilmFavorit_103022400066();
        Favfilm.ReadJSON();
        Watchlist_103022400066 watchlist = new Watchlist_103022400066();
        watchlist.ReadJson();
    }
}



