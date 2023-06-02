using System;
using System.IO.Pipes;

public class Song
{
    private string song { get; set; }
    private string title { get; set; }
    private string artist { get; set; }
	private string genre { get; set; }

    public Song(string title)
    {
        this.title = title;

        bool y = true;
        bool n = false;
        string answer;
        //string[] title = { "Lucid Dreams", "Shape Of You", "SICKO MODE", "Tyler Hero", "Sky", "Rich Spirit", "Make No Sense", "The Real Slim Shady" };
        //Artist artist = new Artist();
        //title = "Lucid Dreams";
        //artist = "Juice WRLD";
    }

    public void getSong(string song)
    {
        this.song = song;
    }
	public void PlayPause(bool y, bool n)
	{
        

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

    public void Next(bool y, bool n)
    {
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

    internal void PlayPause()
    {
        throw new NotImplementedException();
    }

    internal void Next()
    {
        throw new NotImplementedException();
    }
}