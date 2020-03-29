using System;
using System.Collections.Generic;
using WordSearchApplication.Models;

namespace WordSearchApplication
{
    public class WordSearcher
    {
        private List<Coordinate> _output;
        
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