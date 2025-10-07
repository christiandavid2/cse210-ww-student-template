using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nEnter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>() { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count) i = 0;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
