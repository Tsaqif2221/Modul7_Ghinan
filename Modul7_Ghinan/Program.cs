using Modul7_Ghinan;
using System;
class Program_abiyu
{
    static void Main(string[] args)
    {
        var filmFavorit_103022400038 = new FilmFavorit_103022400038();
        filmFavorit_103022400038.ReadJSON();
        var watchlist_103022400038 = new Watchlist_103022400038();
        watchlist_103022400038.ReadJSON();
    }
}
