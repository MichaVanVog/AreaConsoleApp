using AreaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaTest
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 3;
            double expectedResult = 28.2743;

            var circle = new Circle(radius);
            double actualResult = circle.GetArea();

            Assert.AreEqual(expectedResult, actualResult, "Answer is incorrect");
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedResult = 6;

            var circle = new Triangle(sideA, sideB, sideC);
            double actualResult = circle.GetArea();

            Assert.AreEqual(expectedResult, actualResult, "Answer is incorrect");
        }
    }
}