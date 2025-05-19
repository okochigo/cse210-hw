using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        list<int> numbers = new List<int>();
        int number;
        do
        {
            Console.WriteLine("Enter number ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int c# data type)
             sum += num;

        double average = (double)sum / numbers.Count;

        int max = numbers[0];
        foreach (int num in numbers)
            if (num > max)
            max = num;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {max}");


    }
}