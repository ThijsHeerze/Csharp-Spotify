using System;
using System.Xml.Linq;

public class Album
{
    public int id { get; set; }
    public string artist { get; set; }
	public string title { get; set; }

    public Album(int _id, string _artist, string _title)
    {
        this.id = _id;
        this.artist = _artist;
        this.title = _title;
	}
    public string getAlbum()
    {
        return title;
    }
}
