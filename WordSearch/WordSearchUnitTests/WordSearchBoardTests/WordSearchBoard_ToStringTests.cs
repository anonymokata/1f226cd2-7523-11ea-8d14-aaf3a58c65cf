using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardToStringTests
    {
        private WordSearchBoard Board;
        
        [TestMethod]
        public void TestToString()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            Board = new WordSearchBoard(lines);

            Assert.AreEqual("A,B,C\nD,E,F\nG,H,I", Board.ToString());
        }
    }
}