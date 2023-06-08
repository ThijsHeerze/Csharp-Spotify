using System;
using System.Xml.Linq;

public class Album
{
    public int albumId { get; set; }
    public int songId { get; set; }
    public int artistId { get; set; }
    public string artist { get; set; }
	public string title { get; set; }
	public string album { get; set; }
    public string songs { get; set; }
    public Album(int artistId, string artist, int albumId, string title, int songId, string songs)
	{
		this.title = title;
        this.artist = artist;
        this.albumId = albumId;
        this.songId = songId;
        this.songs = songs;
        this.artistId = artistId;
        this.artist = artist;
        this.albumId = albumId;

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
