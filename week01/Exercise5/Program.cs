using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserForName();
        int name = promptuserumber();
        int squard = squardNumber(number);
        DisplayResult(name, squard);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Welcome to the program!? ");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Pease enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquardNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squard)
    {
        Console.WriteLine($"{name}, the square of your number is: {squard}");
    }
}