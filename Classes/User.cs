using System;

public class User
{
	public string userName { get; set; }
    List<User> users = new List<User>();
	public User(string userName)
	{
		this.userName = userName;

	}

	public string getUser()
	{
		return userName;
	}
}
