using System;
using System.Xml.Linq;

public class Album
{
    public string artist { get; set; }
	public string title { get; set; }
    List<Song> songs = new List<Song>();

    public Album(string artist, string title)
    {
        this.artist = artist;
        this.title = title;
	}
    public string getAlbum()
    {
        return title;
    }
}
