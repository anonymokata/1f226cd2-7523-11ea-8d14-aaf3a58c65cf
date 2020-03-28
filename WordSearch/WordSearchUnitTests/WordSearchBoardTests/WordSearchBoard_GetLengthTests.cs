using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardGetLengthTests
    {
        private WordSearchBoard Board;
        
        [TestMethod]
        public void TestWithSmallBoard()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            Board = new WordSearchBoard(lines);

            Assert.AreEqual(3, Board.GetLength());
        }
        
        [TestMethod]
        public void TestWith1CharBoard()
        {
            List<string> lines = new List<string>();
            lines.Add("A");

            Board = new WordSearchBoard(lines);

            Assert.AreEqual(1, Board.GetLength());
        }
    }
}