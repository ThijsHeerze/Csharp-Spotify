namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("");
            song.PlayPause();
            song.Next();
            song.Shuffle();

            Album album = new Album("");
            album.ShowAlbums();

            Artist artist = new Artist("", "", "");
            artist.getArtist();
            artist.setArtist(artist);

            List<Artist> artistList = new List<Artist>();
            artistList.Add(new Artist("Kendrick Lamar", "FEEL.", "DAMN."));

            List<Song> songList = new List<Song>();
            songList.Add(new Song("ELEMENT."));

            List<Album> albumList = new List<Album>();
            albumList.Add(new Album("DAMN."));

            

            Playlist playlist = new Playlist();

            User user = new User();
            user.AddFriend();
            user.DeleteFriend();
        }
    }
}