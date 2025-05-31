
using System;

public class ListingActivity : Activity
{
    private readonly string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n\n{_prompts[rand.Next(_prompts.Length)]}");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n> ");
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"\nYou listed {itemCount} items!");
        End();
    }
}