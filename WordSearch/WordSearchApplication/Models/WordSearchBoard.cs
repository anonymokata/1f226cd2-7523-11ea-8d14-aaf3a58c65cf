using System;
using System.Collections.Generic;

namespace WordSearchApplication.Models
{
    public class WordSearchBoard
    {
        private readonly int _length;
        private readonly char[,] _board;

        /// <summary>
        /// WordSearchBoard constructor accepts the lines of the board as strings and builds the board from those lines
        /// </summary>
        /// <param name="lines">A List of strings that represents the characters on the board separated by ','</param>
        /// <exception cref="ArgumentException">Throws an exception when there are no lines on the board or when
        /// the lines in the list are null or empty strings</exception>
        public WordSearchBoard(List<string> lines)
        {
            if (lines.Count == 0) throw new ArgumentException("Board cannot have 0 lines");
            if (string.IsNullOrEmpty(lines[0])) throw new ArgumentException("Lines on a board cannot be blank or null");

            _board = new char[lines.Count, lines.Count];
            _length = lines.Count;

            for (var i = 0; i < lines.Count; i++)
            {
                string[] temp = lines[i].Split(',');
                
                for (var j = 0; j < lines.Count; j++)
                {
                    _board[j,i] = Convert.ToChar(temp[j]);
                }
            }
        }

        /// <summary>
        /// Returns the length of the board, which is the length of one side of the square word search board
        /// </summary>
        /// <returns>Returns the length of the board, _length</returns>
        public int GetLength()
        {
            return _length;
        }

        /// <summary>
        /// Returns the character at a given position of the board. The position on the board is defined as an integer pair (x,y)
        /// where (0,0) is the top left corner of the board. Incrementing x moves the position to the right and incrementing y
        /// moves the position down.
        /// </summary>
        /// <param name="x">The x-axis position of the character to return relative to the top left corner of the board</param>
        /// <param name="y">The y-axis position of the character to return relative to the top left corner of the board</param>
        /// <returns>Returns the char at the given position on the board</returns>
        /// <exception cref="ArgumentException">Throws an exception when the given coordinates are invalid.
        /// Coordinates are invalid when either coordinate is less than 0 or greater than or equal to the length of the board</exception>
        public char GetCharAt(int x, int y)
        {
            if (x < 0 || y < 0) throw new ArgumentException("Cannot look for a position on the board less than 0");
            if (x >= GetLength() || y >= GetLength()) throw new ArgumentException("Cannot look for a position on the board greater than the size of the board");
            
            return _board[x, y];
        }
    }
}