using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;

namespace WordSearchUnitTests.WordSearchGameTests
{
    [TestClass]
    public class WordSearchGameToStringTests
    {
        private WordSearchGame _game;
        
        [TestMethod]
        public void TestToStringReturnsStringOfBoard()
        {
            List<string> lines = new List<string>();
            lines.Add("ABC,DEF");
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            _game = new WordSearchGame(lines);

            Assert.AreEqual("A,B,C\nD,E,F\nG,H,I", _game.ToString());
        }
    }
}