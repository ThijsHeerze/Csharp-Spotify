using System;

public class Artist
{
	public string name { get; set; }
	public string song { get; set; }
	public string album { get; set; }
	public int id { get; set; }

	//constructor
    public Artist(int id, string name)
	{
		this.id = 0;
		this.name = name;
		this.song

		string[] name = {};
		string[] songs = {};
		string[] albums = {};
		int[] id = {};
		
    }

	public string getArtist()
	{
		return name;
	}

	public void setArtist(Artist artist)
	{
		artist.setArtist(this);
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
