using System;
using System.Collections.Generic;
using WordSearchApplication.Models;

namespace WordSearchApplication
{
    public class WordSearchGame
    {
        private List<string> _words;
        private WordSearchBoard _board;
        
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