using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardGetCharAtWithCoordinateTests
    {
        private WordSearchBoard Board;
        
        [TestMethod]
        public void TestWithValidXY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            Board = new WordSearchBoard(lines);

            Assert.AreEqual('A', Board.GetCharAt(new Coordinate(0,0)));
            Assert.AreEqual('B', Board.GetCharAt(new Coordinate(1,0)));
            Assert.AreEqual('C', Board.GetCharAt(new Coordinate(2,0)));
            
            Assert.AreEqual('D', Board.GetCharAt(new Coordinate(0,1)));
            Assert.AreEqual('E', Board.GetCharAt(new Coordinate(1,1)));
            Assert.AreEqual('F', Board.GetCharAt(new Coordinate(2,1)));
            
            Assert.AreEqual('G', Board.GetCharAt(new Coordinate(0,2)));
            Assert.AreEqual('H', Board.GetCharAt(new Coordinate(1,2)));
            Assert.AreEqual('I', Board.GetCharAt(new Coordinate(2,2)));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithNegativeX()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            Board = new WordSearchBoard(lines);
            Board.GetCharAt(new Coordinate(-1,0));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithNegativeY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            Board = new WordSearchBoard(lines);
            Board.GetCharAt(new Coordinate(0,-1));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidX()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            Board = new WordSearchBoard(lines);
            Board.GetCharAt(new Coordinate(3,0));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            Board = new WordSearchBoard(lines);
            Board.GetCharAt(new Coordinate(0,3));
        }
    }
}