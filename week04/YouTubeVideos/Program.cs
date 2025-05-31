
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Learning C# in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "Can you make a video on LINQ?"));
        video1.AddComment(new Comment("Charlie", "Loved the examples!"));
        videos.Add(video1);

       
        Video video2 = new Video("ASP.NET Core Basics", "TechGuru", 900);
        video2.AddComment(new Comment("Dave", "Super helpful, thanks!"));
        video2.AddComment(new Comment("Eve", "The pacing was perfect."));
        video2.AddComment(new Comment("Frank", "Please cover MVC next."));
        video2.AddComment(new Comment("Grace", "Really well explained!"));
        videos.Add(video2);

     
        Video video3 = new Video("Debugging Tips for Beginners", "DevPro", 450);
        video3.AddComment(new Comment("Hannah", "This saved me hours!"));
        video3.AddComment(new Comment("Ian", "Great tips, especially breakpoints."));
        video3.AddComment(new Comment("Jill", "More debugging videos, please!"));
        videos.Add(video3);

        
        Video video4 = new Video("Intro to OOP", "LearnCode", 720);
        video4.AddComment(new Comment("Kate", "OOP makes so much sense now!"));
        video4.AddComment(new Comment("Liam", "Can you explain inheritance?"));
        video4.AddComment(new Comment("Mia", "Awesome content!"));
        videos.Add(video4);

        
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(); 
        }
    }
}