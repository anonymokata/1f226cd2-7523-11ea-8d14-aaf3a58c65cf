using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardGetCharAtTests
    {
        private WordSearchBoard _board;
        
        [TestMethod]
        public void TestWithValidXY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            _board = new WordSearchBoard(lines);

            Assert.AreEqual('A', _board.GetCharAt(0,0));
            Assert.AreEqual('B', _board.GetCharAt(1,0));
            Assert.AreEqual('C', _board.GetCharAt(2,0));
            
            Assert.AreEqual('D', _board.GetCharAt(0,1));
            Assert.AreEqual('E', _board.GetCharAt(1,1));
            Assert.AreEqual('F', _board.GetCharAt(2,1));
            
            Assert.AreEqual('G', _board.GetCharAt(0,2));
            Assert.AreEqual('H', _board.GetCharAt(1,2));
            Assert.AreEqual('I', _board.GetCharAt(2,2));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithNegativeX()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            _board = new WordSearchBoard(lines);
            _board.GetCharAt(-1, 0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithNegativeY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            _board = new WordSearchBoard(lines);
            _board.GetCharAt(0, -1);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidX()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            _board = new WordSearchBoard(lines);
            _board.GetCharAt(3, 0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidY()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");

            _board = new WordSearchBoard(lines);
            _board.GetCharAt(0, 3);
        }
    }
}