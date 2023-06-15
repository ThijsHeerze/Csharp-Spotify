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
            int option = Convert.ToInt32(Console.ReadLine());
            
            //Playlist playlist = playlist.CreatePlaylist();

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    Playlist playlist1 = new Playlist(1, "Eminem");
                    playlist1.AddSongs(new Song("Lose Yourself"));
                    break;

                case 2:
                    Console.WriteLine();
                    //playlist.ShowPlaylist();

                    break;


                case 3:
                    Song song = new Song();
                    song.PlayPause();
                    song.Next();
                    song.Shuffle();
                    break;
            }

            //Song song = new Song("");
            //song.PlayPause();
            //song.Next();
            //song.Shuffle();

            Album album = new Album();
            album.getAlbum();

            Artist artist = new Artist();
            artist.getArtist();
            artist.setArtist(artist);

            List<Artist> artistList = new List<Artist>;
            artistList.Add(new Artist(1, "Kendrick Lamar"));
            artistList.Add(new Artist(2, "Juice WRLD"));
            artistList.Add(new Artist(3, "Drake"));

            foreach (var Artist in artistList)
            {
                Console.WriteLine($"Name: {artist.name} Singles: {artist.song} Albums: {artist.album}");
            }

            List<Song> songList = new List<Song>();
            songList.Add(new Song("ELEMENT."));
            songList.Add(new Song("Lucid Dreams"));
            songList.Add(new Song("Lose Yourself"));
            songList.Add(new Song("No Love"));

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