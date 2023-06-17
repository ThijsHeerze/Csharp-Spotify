using System;
using System.IO.Pipes;

public class Song
{
    public int id {  get; set; }
    public string title { get; set; }
    public string artist { get; set; }
    public string genre { get; set; }
    public string duration { get; set; }

    public Song(int id, string title, string artist, string genre, string duration)
    {
        this.id = id;
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
    public void PauseNextShuffle()
    {
        Console.WriteLine("1: Pause");
        Console.WriteLine("2: Next");
        Console.WriteLine("3: Shuffle");
        int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Song paused");
                break;

                case 2:
                    Console.WriteLine("Next song");    
                break;

                case 3:
                    Random random = new Random();
                    for (int j = 0; j < 1; j++)
                    {
                        Console.WriteLine("Shuffle mode on");
                    }
                break;
        }
    }
}