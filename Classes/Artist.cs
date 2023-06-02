using System;

public class Artist
{
	public string artistName { get; set; }
	public string song { get; set; }
	public string album { get; set; }

	//List<string> artistList = new List<string>();
    //List<string> songList = new List<string>();
    //List<string> albumList = new List<string>();

    public Artist(string artistName, string song, string album)
	{
		this.artistName = artistName;
		this.song = song;
		this.album = album;

		string[] name = {};
		string[] songs = {};
		string[] albums = {};
		
    }

	public string getArtist()
	{
		return artistName;
	}

	public void setArtist(Artist artist)
	{

	}
}
