using System;
using System.Collections.Generic;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songlist = new List<Song>();
            songlist.Add(new Song("ELEMENT. ", "Kendrick Lamar ", "rap ", "3:16"));
            songlist.Add(new Song("Lucid Dreams", "Juice WRLD", "rap", "4:00"));
            songlist.Add(new Song("NO BYSTANDERS", "Travis Scott", "rap", "3:10"));
            songlist.Add(new Song("Stronger", "Kanye West", "rap", "4:00"));

            Song song = new Song("", "", "", "");
            song.getSong();
            /*song.PlayPause();
            song.Next();
            song.Shuffle();*/

            List<Album> albumlist = new List<Album>();
            albumlist.Add(new Album("Juice WRLD", "Goodbye & Good Riddance"));
            albumlist.Add(new Album("Drake", "Take Care"));
            albumlist.Add(new Album("Kendrick Lamar", "Mr. Morale & The Big Steppers"));

            Album album = new Album("", "");
            album.getAlbum();

            Artist artist = new Artist("", "", "");
            artist.getArtist();

            List<Artist> artistlist = new List<Artist>();
            artistlist.Add(new Artist("Kendrick Lamar", "Money Trees", "good kid m.A.A.d city"));
            artistlist.Add(new Artist("Juice WRLD", "Don't Fall Off", "The Party Never Ends"));
            artistlist.Add(new Artist("Eminem", "The Marshall Mathers LP", "The Real Slim Shady"));

            List<Playlist> playlists = new List<Playlist>();

            Playlist playlist = new Playlist(0, "");
            playlist.getPlaylist();

            List<User> users = new List<User>();

            User user = new User("");
            user.getUser();

            Console.WriteLine("1: Do you want to create a playlist?");
            Console.WriteLine("2: Do you want to select a playlist?");
            Console.WriteLine("3: Do you want to play a song?");
            Console.WriteLine("4: Do you want to listen to an album?");
            Console.WriteLine("5: Do you want to listen to an artist?");
            Console.WriteLine("6: Go to friendlist");

            

            while (true) {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

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

                        playlists.Add(playlist1);
                        playlists.Add(playlist2);
                        playlists.Add(playlist3);

                        Console.WriteLine("Playlists created");
                        break;

                    case 2:
                        Console.WriteLine("What playlist do you want to listen to?");
                        
                        foreach (Playlist _playlist in playlists)
                        {
                            Console.WriteLine(_playlist.playlistId); Console.WriteLine(_playlist.playlistName);
                        }
                        Console.ReadLine();
                        Console.WriteLine("playlist " + playlist.playlistName + "is playing");
                        break;


                    case 3:
                        Console.WriteLine("What song do you want to listen to?");
                        Console.ReadLine();
                        foreach (Song _song in songlist)
                        {
                            Console.WriteLine(_song.title);
                        }

                        break;

                    case 4:
                        Console.WriteLine("What album do you want to listen to?");
                        Console.ReadLine();
                        foreach (Album _album in albumlist)
                        {
                            Console.WriteLine(_album.title);
                        }

                        break;

                    case 5:
                        Console.WriteLine("Who do you want to listen to?");
                        Console.ReadLine();
                        foreach (Artist _artist in artistlist)
                        {
                            Console.WriteLine(_artist.name);
                        }

                        break;

                    case 6:

                        Console.WriteLine("1: ");
                        User user1 = new User("Thijs");
                        Playlist playlist4 = new Playlist(2, "Pop");
                        Playlist playlist5 = new Playlist(2, "Pop");
                        Playlist playlist6 = new Playlist(2, "Pop");
                        User user2 = new User("Floor");
                        Playlist playlist7 = new Playlist(2, "Pop");
                        Playlist playlist8 = new Playlist(2, "Pop");
                        Playlist playlist9 = new Playlist(2, "Pop");
                        User user3 = new User("Marijn");
                        Playlist playlist10 = new Playlist(2, "Pop");
                        Playlist playlist11 = new Playlist(2, "Pop");
                        Playlist playlist12 = new Playlist(2, "Pop");

                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}