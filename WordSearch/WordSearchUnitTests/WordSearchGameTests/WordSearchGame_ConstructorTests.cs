using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;

namespace WordSearchUnitTests.WordSearchGameTests
{
    [TestClass]
    public class WordSearchGameConstructorTests
    {
        private WordSearchGame _game;
        
        [TestMethod]
        public void TestConstructorWithValidList()
        {
            List<string> input = new List<string>();
            
            input.Add("ONE,TWO");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestConstructorWithNullInput()
        {
            _game = new WordSearchGame(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithListWithNullStrings()
        {
            List<string> input = new List<string>();
            input.Add(null);
            
            _game = new WordSearchGame(input);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorWithListWithBlankStrings()
        {
            List<string> input = new List<string>();
            input.Add("");
            
            _game = new WordSearchGame(input);
        }
    }
}