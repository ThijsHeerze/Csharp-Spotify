namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song = new Songs();
            song.PlayPause();
            Album album = new Album();

            Playlist playlist = new Playlist();

            Artist artist = new Artist();
        }
    }
}