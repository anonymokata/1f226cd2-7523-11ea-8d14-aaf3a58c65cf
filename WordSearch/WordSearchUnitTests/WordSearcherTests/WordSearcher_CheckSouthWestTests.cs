using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearcherTests
{
    [TestClass]
    public class WordSearcherCheckSouthWestTests
    {
        private WordSearcher _searcher;
        private WordSearchBoard _board;
        private List<string> _lines;

        private List<Coordinate> _results;
        
        [TestInitialize]
        public void Setup()
        {
            _results = new List<Coordinate>();
            
            _lines = new List<string>();
            _lines.Add("A,B,C");
            _lines.Add("D,E,F");
            _lines.Add("G,H,I");
            
            _board = new WordSearchBoard(_lines);
        }
        
        [TestMethod]
        public void TestWithWordToTheSouthWestReturnCoordinates()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EG";

            _searcher = new WordSearcher();
            _results = _searcher.CheckSouthWest(_board, coordinate, word);
            
            Assert.AreEqual(2, _results.Count);
            Assert.AreEqual(1,_results[0].X);
            Assert.AreEqual(1,_results[0].Y);
            Assert.AreEqual(0,_results[1].X);
            Assert.AreEqual(2,_results[1].Y);
        }

        [TestMethod]
        public void TestWithoutWordToTheSouthWestReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "AB";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckSouthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithCoordinateOnSouthWestEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(0,2);
            string word = "GBA";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckSouthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordReturnNull()
        {
            Coordinate coordinate = new Coordinate(2,0);
            string word = "CEI";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckSouthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordAgainstSouthWestEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EGJ";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckSouthWest(_board, coordinate, word));
        }
    }
}