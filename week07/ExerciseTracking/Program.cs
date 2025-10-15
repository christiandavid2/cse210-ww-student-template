using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 45, 15.0),
            new Swimming("03 Nov 2022", 25, 20)
        };

        Console.WriteLine("=== Exercise Tracker ===\n");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
