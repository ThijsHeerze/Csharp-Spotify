using System;
using System.Collections.Generic;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songlist = new List<Song>();
            songlist.Add(new Song(1, "ELEMENT. ", "Kendrick Lamar ", "rap ", "3:16"));
            songlist.Add(new Song(2, "Lucid Dreams", "Juice WRLD", "rap", "4:00"));
            songlist.Add(new Song(3, "NO BYSTANDERS", "Travis Scott", "rap", "3:10"));
            songlist.Add(new Song(4, "Stronger", "Kanye West", "rap", "4:00"));

            Song song = new Song(0, "", "", "", "");
            song.getSong();
            

            List<Album> albumlist = new List<Album>();
            albumlist.Add(new Album(1, "Juice WRLD", "Goodbye & Good Riddance"));
            albumlist.Add(new Album(2, "Drake", "Take Care"));
            albumlist.Add(new Album(3, "Kendrick Lamar", "Mr. Morale & The Big Steppers"));

            Album album = new Album(0,"", "");
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

            User user = new User(0,"", "");
            //user.getUser();

            while (true) {
            Console.WriteLine("1: Do you want to create a playlist?");
            Console.WriteLine("2: Do you want to select a playlist?");
            Console.WriteLine("3: Do you want to play a song?");
            Console.WriteLine("4: Do you want to listen to an album?");
            Console.WriteLine("5: Do you want to listen to an artist?");
            Console.WriteLine("6: Do you want to select a user?");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Playlist playlist1 = new Playlist(1, "Rap");
                        playlist1.AddSongs(new Song(1, "Lose Yourself", "Eminem", "rap", "5:12"));
                        playlist1.AddSongs(new Song(2, "Fair Trade (with Travis Scott)", "Drake featuring Travis Scott", "rap", "3:42"));
                        Playlist playlist2 = new Playlist(2, "Pop");
                        playlist1.AddSongs(new Song(1, "Style", "Taylor Swift", "pop", "3:03"));
                        playlist1.AddSongs(new Song(2, "Shape Of You", "Ed Sheeran", "pop", "3:10"));
                        Playlist playlist3 = new Playlist(3, "Gym");
                        playlist1.AddSongs(new Song(1, "A New Beginning", "Sub Zero Project", "hardstyle", "2.58"));
                        playlist1.AddSongs(new Song(2, "Lost In Paradise - Edit", "Max Enforcer", "hardstyle", "3:24"));

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
                        
                        foreach (Song _song in songlist)
                        {
                            Console.WriteLine(_song.title);
                        }
                        
                        Console.ReadLine();
                        Console.WriteLine("Song " + song.title + "is playing");
                        song.PauseNextShuffle();
                        break;

                    case 4:
                        Console.WriteLine("What album do you want to listen to?");
                        
                        foreach (Album _album in albumlist)
                        {
                            Console.WriteLine(_album.title);
                        }
                        Console.ReadLine();
                        Console.WriteLine("Album " + album.title + "is playing");
                        song.PauseNextShuffle();
                        break;

                    case 5:
                        Console.WriteLine("Who do you want to listen to?");
                        
                        foreach (Artist _artist in artistlist)
                        {
                            Console.WriteLine(_artist.name);
                        }
                        Console.ReadLine();
                        Console.WriteLine("Artist " + artist.name + "playing");
                        song.PauseNextShuffle();
                        break;

                    case 6:
                        Console.WriteLine("Select an user");
                        foreach (User _user in users)
                        {
                            Console.WriteLine(_user.userName);
                        }
                        
                        User user1 = new User(1, "Thijs", "");
                        Playlist playlist4 = new Playlist(1, "Rap");
                        Playlist playlist5 = new Playlist(2, "Pop");
                        Playlist playlist6 = new Playlist(3, "Gym");
                        User user2 = new User(2, "Floor", "");
                        Playlist playlist7 = new Playlist(1, "Dance");
                        Playlist playlist8 = new Playlist(2, "Pop");
                        Playlist playlist9 = new Playlist(3, "Summer");
                        User user3 = new User(3, "Marijn", "");
                        Playlist playlist10 = new Playlist(1, "Marijn");
                        Playlist playlist11 = new Playlist(2, "Marijnslijst");
                        Playlist playlist12 = new Playlist(3, "Pop");

                        //user.Add(user1);

                        Console.ReadLine();
                        Console.WriteLine("User " + "selected");
                        Console.WriteLine("Add user");
                        foreach (User _user in users)
                        {
                            Console.WriteLine(_user.userPlaylists);
                        }
                        Console.ReadLine();
                        Console.WriteLine("User added");
                        
                        break;
                }
            }
        }
    }
}