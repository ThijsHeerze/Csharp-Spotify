using System;

public class Artist
{
	public string name { get; set; }
	public string song { get; set; }
	public string album { get; set; }

	//constructor
    public Artist(string name, string song, string album)
	{
		this.name = name;
		this.song = song;
		this.album = album;
    }

	public string getArtist()
	{
		return name;
	}

	public string ShowSongs()
	{
		return song;
	}
    public string ShowAlbums()
    {
        return album;
    }

}
