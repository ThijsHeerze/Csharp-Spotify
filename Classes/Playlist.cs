using System;

public class Playlist
{
    public int playlistId { get; set; }
    public string playlistName { get; set; }
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

    public string CreatePlaylist()
    {
        Console.WriteLine("");
        return playlistName;
    }
}
