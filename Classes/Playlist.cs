using System;

public class Playlist
{
    public int id { get; set; }
    public string name { get; set; }
    List<Song> songs = new List<Song>();
	public Playlist(int _id, string _name)
	{
        this.id = _id;
        this.name = _name;
	}

    public string getPlaylist()
    {
        return name;
    }

    public void AddSongs(Song song)
    {
        songs.Add(song);
    }

    public string ShowPlaylist()
    {
        return name;
    }
}
