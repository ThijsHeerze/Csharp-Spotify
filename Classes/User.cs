using System;

public class User
{
	public int userId { get; set; }
	public string userName { get; set; }
    List<User> users = new List<User>();
	public User(int userId, string userName)
	{
		this.userId = userId;
		this.userName = userName;
	}

	public string getUser()
	{
		return userName;
	}
}
