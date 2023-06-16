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
    //alles met int
    public void PlayPause()
    {
        Console.WriteLine("1: Pause");
        if (true)
        {
            Console.WriteLine("Song is paused");
        }
    }

    public void Next()
    {

        Console.WriteLine("2: Next");
        Console.ReadLine();
    }

    public void Shuffle()
    {
        Console.WriteLine("3: Shuffle");


        if (true)
        {
            Random random = new Random();
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(random.Next());
                Console.WriteLine("Shuffle mode on");
            }

            

        } else
        {
            Console.WriteLine("Shuffle mode off");
        }
    }
}