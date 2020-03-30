using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardConstructorTests
    {
        private WordSearchBoard _board;
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullInputThrowsException()
        {
            _board = new WordSearchBoard(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestListWithNullStringsThrowsException()
        {
            List<string> lines = new List<string>();
            lines.Add(null);
            lines.Add(null);
            lines.Add(null);
            
            _board = new WordSearchBoard(lines);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestListWithBlankStringsThrowsException()
        {
            List<string> lines = new List<string>();
            lines.Add("");
            lines.Add("");
            lines.Add("");
            
            _board = new WordSearchBoard(lines);
        }
        
        [TestMethod]
        public void TestListWithValidStrings()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            _board = new WordSearchBoard(lines);
        }
    }
}