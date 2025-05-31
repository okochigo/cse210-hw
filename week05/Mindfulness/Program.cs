
using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing", 0 },
            { "Reflection", 0 },
            { "Listing", 0 }
        };

        while (true)
        {
            Console.WriteLine("\nMindfulness Program Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activityLog["Breathing"]++;
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activityLog["Reflection"]++;
                    break;
                case "3":
                    activity = new ListingActivity();
                    activityLog["Listing"]++;
                    break;
                case "4":
                    Console.WriteLine("\nActivity Log:");
                    foreach (var entry in activityLog)
                    {
                        Console.WriteLine($"{entry.Key} Activity: Performed {entry.Value} time(s)");
                    }
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    continue;
            }

            activity.Run();
        }
    }
}