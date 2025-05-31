
using System;


class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.DisplayGoals();
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nGoal Types: 1. Simple 2. Eternal 3. Checklist");
                Console.Write("Select goal type: ");
                string type = Console.ReadLine();
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    manager.AddGoal(new SimpleGoal(name, description, points));
                }
                else if (type == "2")
                {
                    manager.AddGoal(new EternalGoal(name, description, points));
                }
                else if (type == "3")
                {
                    Console.Write("Enter target times: ");
                    int targetTimes = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, description, points, targetTimes, bonusPoints));
                }
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
                Console.Write("\nEnter goal number to record: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "4")
            {
                manager.SaveGoals(filename);
                Console.WriteLine("\nGoals saved!");
            }
            else if (choice == "5")
            {
                manager.LoadGoals(filename);
                Console.WriteLine("\nGoals loaded!");
            }
            else if (choice == "6")
            {
                Console.WriteLine("\nThank you for using Eternal Quest!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please select 1-6.");
            }
        }
    }
}