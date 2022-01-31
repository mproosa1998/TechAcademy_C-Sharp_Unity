using System;
using System.Collections.Generic;

namespace sixPart_Iteration_Assignment
{
    class Program
    {
        static void Main()
        {
            // Part 1
            string[] lotsOStrings = { "waffle", "jazz", "car", "cat", "star", "frank" };
            Console.WriteLine("Enter text input:");
            string userInput = Console.ReadLine();
            for (int i = 0; i < lotsOStrings.Length; i++)
            {
                lotsOStrings[i] += userInput;
                Console.WriteLine(lotsOStrings[i]);
            }

            // Part 2
            bool escapeClause = false;
            while (!escapeClause)
            {
                Console.WriteLine("type ENTER to end loop:");
                if (Console.ReadLine() == "ENTER")
                {
                    escapeClause = true;
                }
            }

            // Part 3
            int iteration = 0;
            while (iteration < 5)
            {
                Console.WriteLine(iteration);
                iteration++;
            }

            iteration = 0;
            while (iteration <= 5)
            {
                Console.WriteLine(iteration);
                iteration++;
            }

            // Part 4
            HashSet<string> UniqueStrings = new HashSet<string> { "waffle", "jazz", "car", "cat", "star", "frank" };
            Console.WriteLine("\n\nEnter a keyword to search list:");
            string keyword = Console.ReadLine();
            bool keywordFound = false;
            foreach (string uniqueString in UniqueStrings)
            {
                if (uniqueString == keyword)
                {
                    keywordFound = true;
                    continue;
                }
            }
            if (keywordFound)
            {
                Console.WriteLine(keyword + " was found in the list");
            }
            else
            {
                Console.WriteLine(keyword + " was not found in the list");
            }

            // Part 5
            string[] repeatedStrings = { "waffle", "jazz", "car", "waffle", "cat", "star", "frank" };
            keywordFound = false;
            Console.WriteLine("\n\nEnter a keyword to search list:");
            keyword = Console.ReadLine();
            for (int i = 0; i < repeatedStrings.Length; i++)
            {
                if (repeatedStrings[i] == keyword)
                {
                    keywordFound = true;
                    Console.WriteLine(keyword + " found at index: " +i);
                }
            }
            if(!keywordFound)
            {
                Console.WriteLine(keyword + " was not found in the list");
            }
            Console.WriteLine("\n\n");

            // Part 6
            string[] lastStrings = { "waffle", "jazz", "car", "waffle", "cat", "star", "frank" };
            List<string> hasParsed = new List<string>();
            foreach(string laststring in lastStrings)
            {
                bool hasRepeated = false;
                foreach(string parsed in hasParsed)
                {
                    if(parsed == laststring)
                    {
                        hasRepeated = true;
                    }

                }
                if (hasRepeated)
                {
                    Console.WriteLine(laststring + " has been repeated");
                }
                else
                {
                    Console.WriteLine(laststring + " has not been repeated yet");
                }

                hasParsed.Add(laststring);
            }


            Console.ReadLine();
        }
    }
}
