using System;

public class Playlist
{
    public int playlistId { get; set; }
    public string playlistName { get; set; }
    List<Song> songs = new List<Song>();
	public Playlist(int playlistId, string playlistName)
	{
        this.playlistId = playlistId;
        this.playlistName = playlistName;
	}

    public string getPlaylist()
    {
        return playlistName;
    }

    public void setPlaylist(Playlist playlist)
    {

    }

    public void AddSongs(Song song)
    {
        songs.Add(song);
    }
}
