using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;

namespace WordSearchUnitTests.WordSearchGameTests
{
    [TestClass]
    public class WordSearchGameGetWordsListTests
    {
        private WordSearchGame Game;
        
        [TestMethod]
        public void TestGetWordsListWithOneWordReturnsWordList()
        {
            List<string> input = new List<string>();
            
            input.Add("ONE");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            Game = new WordSearchGame(input);
            
            Assert.AreEqual("ONE", Game.GetWordsList()[0]);
            Assert.AreEqual(1, Game.GetWordsList().Count);
        }
        
        [TestMethod]
        public void TestGetWordsListWithMultipleWordsReturnsWordList()
        {
            List<string> input = new List<string>();
            
            input.Add("ONE,TWO,ABC");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            Game = new WordSearchGame(input);
            
            Assert.AreEqual("ONE", Game.GetWordsList()[0]);
            Assert.AreEqual("TWO", Game.GetWordsList()[1]);
            Assert.AreEqual("ABC", Game.GetWordsList()[2]);
            Assert.AreEqual(3, Game.GetWordsList().Count);
        }
        
        [TestMethod]
        public void TestGetWordsListWithNoWordsReturnsEmptyList()
        {
            List<string> input = new List<string>();
            
            input.Add("");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            Game = new WordSearchGame(input);
            
            Assert.AreEqual(0, Game.GetWordsList().Count);
        }
    }
}