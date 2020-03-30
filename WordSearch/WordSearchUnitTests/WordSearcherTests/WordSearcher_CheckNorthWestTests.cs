using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearcherTests
{
    [TestClass]
    public class WordSearcherCheckNorthWestTests
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
        public void TestWithWordToTheNorthWestReturnCoordinates()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EA";

            _searcher = new WordSearcher();
            _results = _searcher.CheckNorthWest(_board, coordinate, word);
            
            Assert.AreEqual(2, _results.Count);
            Assert.AreEqual(1,_results[0].X);
            Assert.AreEqual(1,_results[0].Y);
            Assert.AreEqual(0,_results[1].X);
            Assert.AreEqual(0,_results[1].Y);
        }

        [TestMethod]
        public void TestWithoutWordToTheNorthWestReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "AC";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithCoordinateOnNorthWestEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(0,0);
            string word = "BC";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordReturnNull()
        {
            Coordinate coordinate = new Coordinate(2,2);
            string word = "IEB";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorthWest(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordAgainstNorthWestEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EAC";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorthWest(_board, coordinate, word));
        }
    }
}