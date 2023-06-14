using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Discriminant()
        {
            int a = 3;
            int b = 5;
            int c = 2;
            double expected = 1;


            GeometryTests g = new GeometryTests();
            double actual = g.Discriminant(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
