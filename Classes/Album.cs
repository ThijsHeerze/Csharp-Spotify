using System;
using System.Xml.Linq;

public class Album
{
    public string artist { get; set; }
	public string title { get; set; }
	public string album { get; set; }
    public string songs { get; set; }
    public Album(, string artist, string title, string songs)
    {
        this.artist = artist;
        this.title = title;
        this.songs = songs;
	}
    public string getAlbum()
    {
        return album;
        return title;
        return songs;
    }

    public void setAlbum(Album album)
    {

    }
}
