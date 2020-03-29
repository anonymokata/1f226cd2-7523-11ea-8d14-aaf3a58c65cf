using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.WordSearcherTests
{
    [TestClass]
    public class WordSearcherCheckNorthTests
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
        public void TestWithWordToTheNorthReturnCoordinates()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EB";

            _searcher = new WordSearcher();
            _results = _searcher.CheckNorth(_board, coordinate, word);
            
            Assert.AreEqual(2, _results.Count);
            Assert.AreEqual(1,_results[0].X);
            Assert.AreEqual(1,_results[0].Y);
            Assert.AreEqual(1,_results[1].X);
            Assert.AreEqual(0,_results[1].Y);
        }

        [TestMethod]
        public void TestWithoutWordToTheNorthReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "AG";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorth(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithCoordinateOnNorthEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,0);
            string word = "BAC";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorth(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,2);
            string word = "HEJ";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorth(_board, coordinate, word));
        }

        [TestMethod]
        public void TestWithPartialWordAgainstNorthEdgeReturnNull()
        {
            Coordinate coordinate = new Coordinate(1,1);
            string word = "EBJ";

            _searcher = new WordSearcher();
            
            Assert.IsNull(_searcher.CheckNorth(_board, coordinate, word));
        }
    }
}