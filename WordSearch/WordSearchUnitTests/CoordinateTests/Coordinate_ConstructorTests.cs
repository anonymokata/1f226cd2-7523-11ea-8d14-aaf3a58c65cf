using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSearchApplication.Models;

namespace WordSearchUnitTests.CoordinateTests
{
    [TestClass]
    public class CoordinateConstructorTests
    {
        [TestMethod]
        public void TestConstructorAssignValues()
        {
            Coordinate coordinate = new Coordinate(1,2);
            
            Assert.AreEqual(1, coordinate.X);
            Assert.AreEqual(2, coordinate.Y);
        }
    }
}