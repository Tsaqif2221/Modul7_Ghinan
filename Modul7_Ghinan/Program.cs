using Modul7_Ghinan;
using System;

class program
{
    static void Main(string[] args)
    {
        FilmFavorite FavFilm = new FilmFavorite();
        FavFilm.ReadJSON();

        Console.WriteLine();

        Watchlist_103022400007 WL = new Watchlist_103022400007();
        WL.ReadJSON();
    }
}
