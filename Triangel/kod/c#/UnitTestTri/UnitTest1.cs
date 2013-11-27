using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangelUnitTest
    {
        //Testing Isosceles with different values
        [TestMethod]
        public void IsIsoscelesTest()
        {
            Assert.IsTrue(new Triangle(2.0, 3.0, 2.0).isIsosceles());
            Assert.IsTrue(new Triangle(2, 3, 2).isIsosceles());
            Assert.IsTrue(new Triangle(2.3, 2.3, 3.0).isIsosceles());

            Assert.IsFalse(new Triangle(2.3, 2.4, 3.0).isIsosceles());
            Assert.IsFalse(new Triangle(999.0, 999.0, 999.0).isIsosceles());
            Assert.IsFalse(new Triangle(2, 4, 5).isIsosceles());
        }
        //testing Equilateral with different values
        [TestMethod]
        public void IsEquilateralTest()
        {
            Assert.IsTrue(new Triangle(2.0, 3.0, 4.0).isEquilateral());
            Assert.IsTrue(new Triangle(2, 3, 4).isEquilateral());
            Assert.IsTrue(new Triangle(2.3, 3.3, 4.3).isEquilateral());

            Assert.IsFalse(new Triangle(2.0, 3.0, 2.0).isEquilateral());
            Assert.IsFalse(new Triangle(999.0, 999.0, 999.0).isEquilateral());
            Assert.IsFalse(new Triangle(0, 0, 0).isEquilateral());
        }
        //Testing Scalene with different values
        [TestMethod]
        public void IsScaleneTest()
        {
            Assert.IsTrue(new Triangle(3.0, 3.0, 3.0).isScalene());
            Assert.IsTrue(new Triangle(3, 3, 3).isScalene());

            Assert.IsFalse(new Triangle(3.1, 3.4, 3.7).isScalene());
            Assert.IsFalse(new Triangle(3.0, 4.0, 5.0).isScalene());
            Assert.IsFalse(new Triangle(3.0, 3.0, 4.0).isScalene());
        }
        [TestMethod]
        public void CheckIfTriangle()
        {
            try
            {
                new Triangle(0.0, 0.0, 0.0);
                new Triangle(1.0, 2.0, 3.0);
                new Triangle(2.0, 0.0, 5.0);                
            }
            catch(ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            Assert.Fail("Konstruktorerna kontrollerar inte om det är en triangel");
        }
        [TestMethod]
        public void CheckForNegativeValues()
        {
            Assert.IsFalse(new Triangle(-3.0, -3.0, -3.0).isScalene());
            Assert.IsFalse(new Triangle(-3.0, 3.0, 3.0).isScalene());

            Assert.IsFalse(new Triangle(-3.0, -4.0, -5.0).isEquilateral());
            Assert.IsFalse(new Triangle(3.0, -4.0, 5.0).isEquilateral());

            Assert.IsFalse(new Triangle(-2.0, -2.0, -3.0).isIsosceles());
            Assert.IsFalse(new Triangle(2.0, -2.0, 3.0).isIsosceles());
        }

    }
}