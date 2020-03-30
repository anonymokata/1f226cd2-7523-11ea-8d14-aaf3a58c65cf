using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication;

namespace WordSearchUnitTests.WordSearchGameTests
{
    [TestClass]
    public class WordSearchGameGetWordsAndCoordinatesTests
    {
        private WordSearchGame _game;
        
        [TestMethod]
        public void TestZeroWordsInWordListReturnEmptyDict()
        {
            List<string> input = new List<string>();
            
            input.Add("");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(0,output.Count);
        }
        
        [TestMethod]
        public void TestOneWordInWordListReturnValuesInDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ONE");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(1,output.Count);
            Assert.AreEqual("(0,0),(1,0),(2,0)", output["ONE"][0]);
        }
        
        [TestMethod]
        public void TestManyWordsInWordListReturnValuesInDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ONE,TWO,ABC,ENO,OWT,CBA,ATO,BWN,COE,OTA,NWB,EOC,OWC,EWA");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(14,output.Count);
            Assert.AreEqual("(0,0),(1,0),(2,0)", output["ONE"][0]);
            Assert.AreEqual("(0,2),(0,1),(0,0)", output["ATO"][0]);
            Assert.AreEqual("(2,0),(1,1),(0,2)", output["EWA"][0]);
        }
        
        [TestMethod]
        public void TestNoWordsOnBoardReturnEmptyDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ZYX,JCK,CHI");
            input.Add("O,N,E");
            input.Add("T,W,O");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(0,output.Count);
        }
        
        [TestMethod]
        public void TestOneWordOnBoardReturnValuesInDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ZYX,JCK,CHI");
            input.Add("O,N,E");
            input.Add("J,C,K");
            input.Add("A,B,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(1,output.Count);
            Assert.AreEqual("(0,1),(1,1),(2,1)", output["JCK"][0]);
        }
        
        [TestMethod]
        public void TestManyWordsOnBoardReturnValuesInDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ZYX,JCK,CHI");
            input.Add("X,Y,Z");
            input.Add("J,C,K");
            input.Add("I,H,C");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(3,output.Count);
            Assert.AreEqual("(2,0),(1,0),(0,0)", output["ZYX"][0]);
            Assert.AreEqual("(0,1),(1,1),(2,1)", output["JCK"][0]);
            Assert.AreEqual("(2,2),(1,2),(0,2)", output["CHI"][0]);
        }
        
        [TestMethod]
        public void TestNoOccurrencesOfFirstLetterOnBoardReturnEmptyDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ABC,DEF,GEH");
            input.Add("Z,Y,X");
            input.Add("W,V,U");
            input.Add("T,S,R");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(0,output.Count);
        }
        
        [TestMethod]
        public void TestOneOccurrenceOfFirstLetterOnBoardReturnEmptyDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ABC,DEF,GEH");
            input.Add("Z,Y,X");
            input.Add("W,A,U");
            input.Add("T,S,R");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(0,output.Count);
        }
        
        [TestMethod]
        public void TestManyOccurrencesOfFirstLetterOnBoardReturnEmptyDict()
        {
            List<string> input = new List<string>();
            
            input.Add("ABC,DEF,GEH");
            input.Add("A,A,A");
            input.Add("A,A,A");
            input.Add("A,A,A");
            
            _game = new WordSearchGame(input);
            Dictionary<string, List<string>> output = _game.GetWordsAndCoordinates();

            Assert.AreEqual(0,output.Count);
        }
    }
}