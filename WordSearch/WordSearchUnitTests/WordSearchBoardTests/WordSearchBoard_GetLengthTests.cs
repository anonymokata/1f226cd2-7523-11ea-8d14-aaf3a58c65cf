using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardGetLengthTests
    {
        private WordSearchBoard _board;
        
        [TestMethod]
        public void TestWithSmallBoard()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            _board = new WordSearchBoard(lines);

            Assert.AreEqual(3, _board.GetLength());
        }
        
        [TestMethod]
        public void TestWith1CharBoard()
        {
            List<string> lines = new List<string>();
            lines.Add("A");

            _board = new WordSearchBoard(lines);

            Assert.AreEqual(1, _board.GetLength());
        }
    }
}