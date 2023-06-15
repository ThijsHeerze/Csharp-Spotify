using System;
using System.IO.Pipes;

public class Song
{
    public string title { get; set; }
    public string artist { get; set; }
	public string genre { get; set; }
    public string duration { get; set; }

    public Song(string title, string artist, string genre, string duration)
    {
        this.title = title;
        this.artist = artist;
        this.genre = genre;
        this.duration = duration;
    }

    public string getSong()
    {
        return title;
    }

    public void setSong(Song song)
    {
        
    }
	public void PlayPause()
	{
        bool y = true;
        bool n = false;

        Console.WriteLine("The song " + title + " by " + artist + " is playing");
        Thread.Sleep(1000);

        while (true)
        {
            Console.WriteLine("Play this song(y/n)?");
            Console.ReadLine();
            if (y)
            {
                Console.WriteLine("Song is playing");
            } else
            {
                Console.WriteLine("Song is paused");
            }
        }
        
    }

    public void Next()
    {
        bool y = true;
        bool n = false;

        if (y) { 
        Console.WriteLine("Next song(y/n)?");
        Console.ReadLine();
    } if (y)
            {
                Console.WriteLine("The song " + title + " by " + artist + " is playing");
            }
    }

    public void Shuffle()
    {
        Console.WriteLine("Do you want to shuffle?(y/n)");
        bool y = true;
        bool n = false;
        if (y)
        {
            Random random = new Random();
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(random.Next());
                Console.WriteLine("Shuffle mode on");
            }
        } if (n) {
            Console.WriteLine("Shuffle mode off");
        }
    }
}