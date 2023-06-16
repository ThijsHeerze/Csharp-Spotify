using System;

public class User
{
	public int userId { get; set; }
	public string userName { get; set; }
	public string userPlaylists { get; set; }
	public User(int userId, string userName, string userPlaylists)
	{
		this.userId = userId;
		this.userName = userName;
		this.userPlaylists = userPlaylists;
	}

	public string getUser()
	{
		return userName;
	}
}
