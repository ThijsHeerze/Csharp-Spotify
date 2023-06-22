﻿using System;

public class Playlist
{
    public int id { get; set; }
    public string name { get; set; }
    public User user { get; set; }
    public List<Song> songs { get; set; }
	public Playlist(int _id, string _name, User user)
	{
        this.id = _id;
        this.name = _name;
        this.user = user;
        this.songs = new List<Song>();
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
