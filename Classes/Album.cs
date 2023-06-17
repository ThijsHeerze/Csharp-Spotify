using System;
using System.Xml.Linq;

public class Album
{
    public int id { get; set; }
    public string artist { get; set; }
	public string title { get; set; }

    public Album(int id, string artist, string title)
    {
        this.id = id;
        this.artist = artist;
        this.title = title;
	}
    public string getAlbum()
    {
        return title;
    }
}
