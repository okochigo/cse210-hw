using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int randomNumber = randomgenerator.Next(1, 101);
        int guess;

        do
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < randomNumber)
            
                Console.WriteLine("Higher");
            
            else if (guess > randomNumber)
            
                Console.WriteLine("Lower");
            
            
            else
            
                Console.WriteLine("You guessed it!");
            
        } while (guess != randomNumber);
    }
}