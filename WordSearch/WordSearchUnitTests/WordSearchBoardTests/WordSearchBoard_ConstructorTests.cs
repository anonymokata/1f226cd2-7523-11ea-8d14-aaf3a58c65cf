using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearchBoardTests
{
    [TestClass]
    public class WordSearchBoardConstructorTests
    {
        private WordSearchBoard Board;

        //Constructor tests: 
        //valid list of lines
        //pass in null
        //pass in list will null strings
        //pass in list with empty strings
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNullInputThrowsException()
        {
            Board = new WordSearchBoard(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestListWithNullStringsThrowsException()
        {
            List<string> lines = new List<string>();
            lines.Add(null);
            lines.Add(null);
            lines.Add(null);
            
            Board = new WordSearchBoard(lines);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestListWithBlankStringsThrowsException()
        {
            List<string> lines = new List<string>();
            lines.Add("");
            lines.Add("");
            lines.Add("");
            
            Board = new WordSearchBoard(lines);
        }
        
        [TestMethod]
        public void TestListWithValidStrings()
        {
            List<string> lines = new List<string>();
            lines.Add("A,B,C");
            lines.Add("D,E,F");
            lines.Add("G,H,I");
            
            Board = new WordSearchBoard(lines);
        }
    }
}