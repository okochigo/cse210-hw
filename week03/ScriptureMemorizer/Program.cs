using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
        List<(Reference, string)> scriptures = LoadScripturesFromFile("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found. Exiting.");
            return;
        }

        Random random = new Random();
        var selected = scriptures[random.Next(scriptures.Count)];
        Scripture scripture = new Scripture(selected.Item1, selected.Item2);

    
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWords(3)) 
                break; 

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden! Program ending.");
                break;
            }
        }
    }

    static List<(Reference, string)> LoadScripturesFromFile(string filename)
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>();
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');
                if (parts.Length < 2)
                    continue;

                string[] refParts = parts[0].Split(' ');
                if (refParts.Length < 2)
                    continue;

                string book = refParts[0];
                string[] chapterVerse = refParts[1].Split(':');
                if (chapterVerse.Length < 2)
                    continue;

                int chapter = int.Parse(chapterVerse[0]);
                string[] verses = chapterVerse[1].Split('-');
                Reference reference;
                if (verses.Length == 1)
                    reference = new Reference(book, chapter, int.Parse(verses[0]));
                else
                    reference = new Reference(book, chapter, int.Parse(verses[0]), int.Parse(verses[1]));

                scriptures.Add((reference, parts[1]));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
        return scriptures;
    }
}