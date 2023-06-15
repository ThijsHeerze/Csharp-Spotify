using System;
using System.Collections.Generic;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Do you want to create a playlist?");
            Console.WriteLine("2: Do you want to select a playlist?");
            Console.WriteLine("3: Do you want to play a song?");
            Console.WriteLine("4: Do you want to listen to an album?");
            Console.WriteLine("5: Do you want to listen to an artist?");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    List<Song> songs = new List<Song>();
                    Console.WriteLine();
                    Playlist playlist1 = new Playlist(1, "Rap");
                    playlist1.AddSongs(new Song("Lose Yourself", "Eminem", "rap", "5:12"));
                    playlist1.AddSongs(new Song("Fair Trade (with Travis Scott)", "Drake featuring Travis Scott", "rap", "3:42"));
                    Playlist playlist2 = new Playlist(2, "Pop");
                    playlist1.AddSongs(new Song("Style", "Taylor Swift", "pop", "3:03"));
                    playlist1.AddSongs(new Song("Shape Of You", "Ed Sheeran", "pop", "3:10"));
                    Playlist playlist3 = new Playlist(3, "Gym");
                    playlist1.AddSongs(new Song("A New Beginning", "Sub Zero Project", "hardstyle", "2.58"));
                    playlist1.AddSongs(new Song("Lost In Paradise - Edit", "Max Enforcer", "hardstyle", "3:24"));
                    break;

                case 2:
                    Console.WriteLine();
                    //playlist.ShowPlaylist();

                    break;


                case 3:
                    foreach (Song song in songs)
                    {
                        Console.WriteLine(song);
                    }
                    
                    break;

                case 4:
                    Console.WriteLine();

                    break;

                case 5:
                    Console.WriteLine(); 

                    break;
            }

            Song song = new Song("","","","");
            song.PlayPause();
            song.Next();
            song.Shuffle();

            songlist.Add(new Song("ELEMENT. ", "Kendrick Lamar ", "rap ", "3:16"));
            songlist.Add(new Song("Lucid Dreams", "Juice WRLD", "rap", "4:00"));
            songlist.Add(new Song("NO BYSTANDERS", "Travis Scott", "rap", "3:"));
            songlist.Add(new Song("No Love", "Eminem featuring Lil Wayne", "rap", "4:12"));

            Album album = new Album("","");
            album.getAlbum();

            Artist artist = new Artist("","","");
            artist.getArtist();
            artist.setArtist(artist);

            List<Artist> artistList = new List<Artist>();
            artistList.Add(new Artist("Kendrick Lamar", "Money Trees", "good kid m.A.A.d city"));
            artistList.Add(new Artist("Juice WRLD",  "Don't Fall Off", "The Party Never Ends"));
            artistList.Add(new Artist("Eminem", "The Marshall Mathers LP", "The Real Slim Shady"));

            foreach (var Artist in artistList)
            {
                Console.WriteLine($"Name: {artist.name} Singles: {artist.song} Albums: {artist.album}");
            }

            List<Song> song = new List<Song>();
            song.Add(new Song("ELEMENT."));
            song.Add(new Song("Lucid Dreams"));
            song.Add(new Song("Lose Yourself"));
            song.Add(new Song("No Love"));

            List<List<List<Album>>> albumList = new List<List<List<Album>>>();
            albumList.Add(new Album(artistId: 1, artist: "Juice WRLD", albumId: 1, title: "Goodbye & Good Riddance",
                songId: 0, songs:
                    1, "Intro",
                    2, "All Girls Are The Same", 
                    3, "Lucid Dreams", 
                    4, "Wasted(feat. Lil Uzi Vert)", 
                    5, "Armed And Dangerous",
                    6, "Black & White", 
                    7, "Lean Wit Me", 
                    8, "I'll Be Fine",
                    9, "Used To",
                    10, "Candles",
                    11, "Scared Of Love",
                    12, "Hurt Me",
                    13, "I'm Still",
                    14, "End Of The Road",
                    15, "Long Gone",
                    16, "Betrayal - Skit",
                    17, "Karma - Skit"
                ));

            Playlist playlist = new Playlist();
            playlist.getPlaylist();
            playlist.setPlaylist(playlist);

            User user = new User();
            user.getUser();
            user.setUser(user);
        }
    }
}