using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        Video video1 = new Video("Learning C# Basics", "John Doe", 600);
        Video video2 = new Video("Advanced C# OOP Concepts", "Jane Smith", 1200);
        Video video3 = new Video("C# Projects for Beginners", "Tech Academy", 900);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I finally understand classes!"));

      
        video2.AddComment(new Comment("David", "Loved the deep dive into OOP."));
        video2.AddComment(new Comment("Emma", "Clear and concise examples."));
        video2.AddComment(new Comment("Frank", "This was super helpful."));

       
        video3.AddComment(new Comment("Grace", "Perfect for beginners!"));
        video3.AddComment(new Comment("Henry", "Easy to follow."));
        video3.AddComment(new Comment("Ivy", "Thanks for this tutorial."));

       
        List<Video> videos = new List<Video> { video1, video2, video3 };

      
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
        }
    }
}
