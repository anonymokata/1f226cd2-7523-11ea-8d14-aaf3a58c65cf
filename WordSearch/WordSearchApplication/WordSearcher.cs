using System;
using System.Collections.Generic;
using WordSearchApplication.Models;

namespace WordSearchApplication
{
    public class WordSearcher
    {
        private List<Coordinate> _output;
        
        /// <summary>
        /// Searches North for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckNorth(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X, tempCoordinate.Y - 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }

        /// <summary>
        /// Searches North-East for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckNorthEast(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X + 1, tempCoordinate.Y - 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }
        
        /// <summary>
        /// Searches East for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckEast(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X + 1, tempCoordinate.Y);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    //Return null because we know words cannot wrap around to another part of the board
                    return null;
                }
            }
            
            return _output;
        }
        
        /// <summary>
        /// Searches South-East for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckSouthEast(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X + 1, tempCoordinate.Y + 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }
        
        /// <summary>
        /// Searches South for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckSouth(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X, tempCoordinate.Y + 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }
        
        /// <summary>
        /// Searches South-West for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckSouthWest(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X - 1, tempCoordinate.Y + 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }
        
        /// <summary>
        /// Searches West for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckWest(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X - 1, tempCoordinate.Y);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;        
        }
        
        /// <summary>
        /// Searches North-West for a given word on a given board starting at a given origin point. If it finds the word,
        /// it returns a list of all of the coordinates that make up the word. Otherwise, it returns null
        /// </summary>
        /// <param name="board">WordSearchBoard to search on</param>
        /// <param name="origin">Coordinate point to begin searching</param>
        /// <param name="word">Word to search for</param>
        /// <returns>If it finds the word, returns a list of all of the coordinates that make up the word. Otherwise, it returns null</returns>
        public List<Coordinate> CheckNorthWest(WordSearchBoard board, Coordinate origin, string word)
        {
            _output = new List<Coordinate>();
            
            Coordinate tempCoordinate = new Coordinate(origin.X, origin.Y);

            foreach (char letter in word)
            {
                try
                {
                    if (board.GetCharAt(tempCoordinate) == letter)
                    {
                        _output.Add(tempCoordinate);
                        tempCoordinate = new Coordinate(tempCoordinate.X - 1, tempCoordinate.Y - 1);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (ArgumentException e)
                {
                    //ArgumentException here means that the tempCoordinate is pointed to an invalid coordinate off the board
                    return null;
                }
            }
            
            return _output;
        }
    }
}