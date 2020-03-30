using System;
using System.Collections.Generic;
using WordSearchApplication.Models;

namespace WordSearchApplication
{
    public class WordSearchGame
    {
        private readonly List<string> _words;
        private readonly WordSearchBoard _board;
        
        /// <summary>
        /// Accepts list of all of the lines given to the application and sets up the game
        /// </summary>
        /// <param name="inputLines">List of all of the lines in the input file</param>
        /// <exception cref="ArgumentException">Exception thrown if there are 0 lines in the input file or if the list of words (first line) is null or empty</exception>
        public WordSearchGame(List<string> inputLines)
        {
            _words = new List<string>();

            if (inputLines.Count == 0) throw new ArgumentException("Board cannot have 0 lines");
            if (inputLines[0] == null) throw new ArgumentException("List of words cannot be null");
            
            if (inputLines[0].Length > 0)
                _words.AddRange(inputLines[0].Split(","));

            inputLines.RemoveAt(0);
            
            _board = new WordSearchBoard(inputLines);
        }

        /// <summary>
        /// Returns a dictionary where a string is mapped to a list of strings. The string is a word from the word list.
        /// The list of strings is the list of occurrences of that word on the board
        /// </summary>
        /// <returns>Returns a dictionary where words from the word list are mapped to a list occurrences of that word on the board</returns>
        public Dictionary<string, List<string>> GetWordsAndCoordinates()
        {
            Dictionary<string, List<string>> output = new Dictionary<String, List<string>>();

            foreach (string word in GetWordsList())
            {
                List<Coordinate> coordinatesOfFirstLetter = GetCoordinatesContainingChar(word[0]);
                List<string> coordinateStrings = GetOccurrencesOfWordGivenFirstLetterCoordinates(word, coordinatesOfFirstLetter);

                if (coordinateStrings.Count > 0)
                {
                    output.Add(word, coordinateStrings);
                }
            }
            
            return output;
        }

        /// <summary>
        /// This method returns a list of all of the occurrences of a given word when we are given list of all of the
        /// instances of the first letter of that word on the board
        /// </summary>
        /// <param name="word">The word we are currently searching for</param>
        /// <param name="coordinatesOfFirstLetter">A list of occurrences of the first letter of word on the board </param>
        /// <returns>Returns a list of occurrences of word on the board</returns>
        private List<string> GetOccurrencesOfWordGivenFirstLetterCoordinates(string word, List<Coordinate> coordinatesOfFirstLetter)
        {
            WordSearcher searcher = new WordSearcher();
            List<string> coordinateStrings = new List<string>();

            foreach (Coordinate firstLetter in coordinatesOfFirstLetter)
            {
                List<List<Coordinate>> occurrencesOfCurrentWord = new List<List<Coordinate>>();
                occurrencesOfCurrentWord.Add(searcher.CheckNorth(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckNorthEast(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckEast(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckSouthEast(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckSouth(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckSouthWest(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckWest(_board, firstLetter, word));
                occurrencesOfCurrentWord.Add(searcher.CheckNorthWest(_board, firstLetter, word));
                    
                foreach (List<Coordinate> coordinateList in occurrencesOfCurrentWord)
                {
                    string tempCoordinateString = BuildCoordinateString(coordinateList);
                    
                    if (!string.IsNullOrEmpty(tempCoordinateString))
                    {
                        coordinateStrings.Add(tempCoordinateString);
                    }
                }
            }

            return coordinateStrings;
        }

        private string BuildCoordinateString(List<Coordinate> coordinates)
        {
            string output = "";
            
            if (coordinates != null)
            {
                foreach (Coordinate coordinate in coordinates)
                {
                    output += coordinate + ",";
                }
            }

            return output.TrimEnd(',');
        }

        /// <summary>
        /// Returns a list of coordinates that contain the character letter
        /// </summary>
        /// <param name="letter">The character that we are searching the board for</param>
        /// <returns>Returns a list of coordinates that contain the character letter</returns>
        private List<Coordinate> GetCoordinatesContainingChar(char letter)
        {
            List<Coordinate> output = new List<Coordinate>();

            for (int y = 0; y < _board.GetLength(); y++)
            {
                for (int x = 0; x < _board.GetLength(); x++)
                {
                    if (_board.GetCharAt(x, y) == letter)
                    {
                        output.Add(new Coordinate(x,y));
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// Returns the list of words passed into the game via the first line of the input file
        /// </summary>
        /// <returns>List of strings in the words list</returns>
        public List<string> GetWordsList()
        {
            return _words;
        }

        /// <summary>
        /// Overrides the ToString method to return a string representation of the board
        /// </summary>
        /// <returns>Returns string representation of the board</returns>
        public override string ToString()
        {
            return _board.ToString();
        }
    }
}