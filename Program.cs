using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songlist = new List<Song>();
            songlist.Add(new Song(1, "Money Trees ", "Kendrick Lamar ", "rap ", "3:16"));
            songlist.Add(new Song(2, "Lucid Dreams", "Juice WRLD", "rap", "4:00"));
            songlist.Add(new Song(3, "goosebumps", "Travis Scott", "rap", "3:10"));
            songlist.Add(new Song(4, "Blood On The Leaves", "Kanye West", "rap", "4:00"));

            Song song = new Song(0, "", "", "", "");
            

            List<Album> albumlist = new List<Album>();
            albumlist.Add(new Album(1, "Juice WRLD", "Goodbye & Good Riddance"));
            albumlist.Add(new Album(2, "Drake", "Take Care"));
            albumlist.Add(new Album(3, "Kendrick Lamar",  "Mr. Morale & The Big Steppers"));
            albumlist.Add(new Album(3, "Kanye West", "Graduation"));

            Album album = new Album(0, "", "");

            Artist artist = new Artist(0, "", "", "");

            List<Artist> artistlist = new List<Artist>();
            artistlist.Add(new Artist(1, "Kendrick Lamar", "Money Trees", "good kid m.A.A.d city"));
            artistlist.Add(new Artist(2, "Juice WRLD", "Don't Fall Off", "The Party Never Ends"));
            artistlist.Add(new Artist(3, "Eminem", "The Marshall Mathers LP", "The Real Slim Shady"));
            
            List<User> users = new List<User>();
            List<Playlist> playlists = new List<Playlist>();

            User user = new User(0,"Thijs");
            Playlist playlist = new Playlist("Playlist", user); 

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
                        Playlist playlist1 = new Playlist("Rap", user);
                        playlist1.AddSongs(new Song(1, "Lose Yourself", "Eminem", "rap", "5:12"));
                        playlist1.AddSongs(new Song(2, "Fair Trade (with Travis Scott)", "Drake featuring Travis Scott", "rap", "3:42"));
                        Playlist playlist2 = new Playlist("Pop", user);
                        playlist2.AddSongs(new Song(1, "Style", "Taylor Swift", "pop", "3:03"));
                        playlist2.AddSongs(new Song(2, "Shape Of You", "Ed Sheeran", "pop", "3:10"));
                        Playlist playlist3 = new Playlist("Gym", user);
                        playlist3.AddSongs(new Song(1, "A New Beginning", "Sub Zero Project", "hardstyle", "2.58"));
                        playlist3.AddSongs(new Song(2, "Lost In Paradise - Edit", "Max Enforcer", "hardstyle", "3:24"));

                        playlists.Add(playlist1);
                        playlists.Add(playlist2);
                        playlists.Add(playlist3);

                        Console.WriteLine("Playlists created");
                        break;

                    case 2:
                        Console.WriteLine("What playlist do you want to listen to?");
                        int p = 0;
                        foreach (Playlist _playlist in playlists)
                        {                           
                            Console.Write(p + " - ");
                            Console.WriteLine(_playlist.name);
                            p++;
                         
                            foreach (Song _song in _playlist.songs)
                            {
                                Console.WriteLine(_song.getSong()); 
                            }
                        }

                        Console.WriteLine("playlist " + playlists.ElementAt(int.Parse(Console.ReadLine())).name + " is playing");
                        song.PauseNextShuffle();
                            
                        break;

                    case 3:
                        Console.WriteLine("What song do you want to listen to?");
                        int s = 0;
                        foreach (Song _song in songlist)
                        {
                            Console.Write(s + " - ");
                            Console.WriteLine(_song.title);
                            s++;
                        }
                        
                        Console.WriteLine("Song " + songlist.ElementAt(int.Parse(Console.ReadLine())).title + " is playing");
                        song.PauseNextShuffle();
                        break;

                    case 4:
                        Console.WriteLine("What album do you want to listen to?");
                        int a = 0;
                        foreach (Album _album in albumlist)
                        {
                            Console.Write(a + " - ");
                            Console.WriteLine(_album.title);
                            a++;
                        }

                        Console.WriteLine("Album " + albumlist.ElementAt(int.Parse(Console.ReadLine())).title + " is playing");
                        song.PauseNextShuffle();
                        break;

                    case 5:
                        Console.WriteLine("Who do you want to listen to?");
                        int i = 0;
                        foreach (Artist _artist in artistlist)
                        {
                            Console.Write(i + " - ");
                            Console.WriteLine(_artist.name);
                            i++;
                        }

                        Console.WriteLine("Artist " + artistlist.ElementAt(int.Parse(Console.ReadLine())).name + " playing");
                        song.PauseNextShuffle();
                        break;

                    case 6:
                        Console.WriteLine("Select an user");
                        i = 0;
                        foreach (User _user in users)
                        {
                            Console.Write(i + " - ");
                            Console.WriteLine(_user.name);
                            i++;
                        }
                        
                        //new users
                        User user1 = new User(1, "Thijs");
                        Playlist playlist4 = new Playlist("Rap", user1);
                        Playlist playlist5 = new Playlist("Pop", user1);
                        Playlist playlist6 = new Playlist("Gym", user1);
                        user1.AddPlaylist(playlist4);
                        user1.AddPlaylist(playlist5);
                        user1.AddPlaylist(playlist6);
                        User user2 = new User(2, "Floor");
                        Playlist playlist7 = new Playlist("Dance", user2);
                        Playlist playlist8 = new Playlist("Summer", user2);
                        user1.AddPlaylist(playlist7);
                        user1.AddPlaylist(playlist8);
                        User user3 = new User(3, "Marijn");
                        Playlist playlist9 = new Playlist("Marijnslijst", user3);
                        Playlist playlist10 = new Playlist("Pop", user3);
                        user1.AddPlaylist(playlist9);
                        user1.AddPlaylist(playlist10);

                        playlists.Add(playlist4);
                        playlists.Add(playlist5);
                        playlists.Add(playlist6);

                        playlists.Add(playlist7);
                        playlists.Add(playlist8);

                        playlists.Add(playlist9);
                        playlists.Add(playlist10);

                        users.Add(user1);
                        users.Add(user2);
                        users.Add(user3);

                        int u = 0;
                        foreach (User _user in users)
                        {
                            Console.Write(u + " - ");
                            Console.WriteLine(_user.name);
                            u++;
                        }
                        Console.WriteLine("User " + users.ElementAt(int.Parse(Console.ReadLine())).name + " selected");                                                                   

                        Console.WriteLine(users.ElementAt(0).name + " playlists");
                        int _p = 0;
                        foreach (Playlist _playlist in users.ElementAt(0).playlists)
                        {
                            Console.Write(_p + " - ");
                            Console.WriteLine(_playlist.name);
                            _p++;
                        }

                        Console.WriteLine("Add user?");
                        Console.WriteLine("User " + users.ElementAt(int.Parse(Console.ReadLine())).name + " added");

                        break;
                }
            }
        }
    }
}