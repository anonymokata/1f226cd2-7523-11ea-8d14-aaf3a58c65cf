using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.CoordinateTests
{
    [TestClass]
    public class CoordinateToStringTests
    {
        [TestMethod]
        public void TestToStringReturnsValidString()
        {
            Coordinate coordinate = new Coordinate(1,2);
            
            Assert.AreEqual("(1,2)", coordinate.ToString());
        }
    }
}