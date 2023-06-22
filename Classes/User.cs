using System;

public class User
{
	public int id { get; set; }
	public string name { get; set; }
	//public string playlists { get; set; }
	public User(int _id, string _name, string _playlists)
	{
		this.id = _id;
		this.name = _name;
		//this.playlists = _playlists;
	}

	public string getUser()
	{
		return name;
	}
}
