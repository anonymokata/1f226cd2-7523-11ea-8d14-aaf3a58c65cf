using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordSearchApplication
{
    public static class WordSearchGamePlayer
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! This is my implementation of the Word Search Kata.");

            while (true)
            {
                Console.WriteLine("Please type a path to your input text file or type 'quit' and press enter: ");
                string filePath = Console.ReadLine();

                if (filePath == "quit") break;
                
                string[] linesFromFile;

                try
                {
                    linesFromFile = File.ReadAllLines(filePath);
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("I'm sorry, I couldn't find that directory. Message: " + e.Message);
                    Console.WriteLine("Please try again!");
                    continue;
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("I'm sorry, I couldn't find that file. Message: " + e.Message);
                    Console.WriteLine("Please try again!");
                    continue;
                }
            
                WordSearchGame game = new WordSearchGame(linesFromFile.ToList());
            
                Console.WriteLine("");

                Dictionary<string, List<string>> output = game.GetWordsAndCoordinates();

                foreach (KeyValuePair<string, List<string>> word in output)
                {
                    foreach (string coordinate in word.Value)
                    {
                        Console.WriteLine(word.Key + ": " + coordinate);
                    }
                }
            }
        }
    }
}