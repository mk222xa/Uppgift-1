using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
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
        public void IsScaleneTest()
        {
            Assert.IsTrue(new Triangle(2.0, 3.0, 4.0).isScalene());
            Assert.IsTrue(new Triangle(2, 3, 4).isScalene());
            Assert.IsTrue(new Triangle(2.3, 3.3, 4.3).isScalene());

            Assert.IsFalse(new Triangle(2.0, 3.0, 2.0).isScalene());
            Assert.IsFalse(new Triangle(999.0, 999.0, 999.0).isScalene());
            Assert.IsFalse(new Triangle(0, 0, 0).isScalene());
        }
        //Testing Scalene with different values
        [TestMethod]
        public void IsEquilateralTest()
        {
            Assert.IsTrue(new Triangle(3.0, 3.0, 3.0).isEquilateral());
            Assert.IsTrue(new Triangle(3, 3, 3).isEquilateral());

            Assert.IsFalse(new Triangle(3.1, 3.4, 3.7).isEquilateral());
            Assert.IsFalse(new Triangle(3.0, 4.0, 5.0).isEquilateral());
            Assert.IsFalse(new Triangle(3.0, 3.0, 4.0).isEquilateral());
        }
        //Check if the input is a valid triangle
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
        //Testing if negative values are caught
        [TestMethod]        
        public void CheckForNegativeValues()
        {
            Assert.IsFalse(new Triangle(-3.0, -3.0, -3.0).isEquilateral());
            Assert.IsFalse(new Triangle(-3.0, 3.0, 3.0).isEquilateral());

            Assert.IsFalse(new Triangle(-3.0, -4.0, -5.0).isScalene());
            Assert.IsFalse(new Triangle(3.0, -4.0, 5.0).isScalene());

            Assert.IsFalse(new Triangle(-2.0, -2.0, -3.0).isIsosceles());
            Assert.IsFalse(new Triangle(2.0, -2.0, 3.0).isIsosceles());
        }
        //Testing the Point constructor
        [TestMethod]
        public void PointConstructor()
        {
            try
            {
                new Triangle(new Point(4, 4), new Point(7, 7), new Point(9, 9));
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        //Testing the point array constructor
        [TestMethod]
        public void PointArrayTest()
        {
            try
            {
                new Triangle(new Point[] { new Point(4, 4), new Point(4, 4), new Point(4, 4) });
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        //Testing the array constructor
        [TestMethod]
        public void ArrayConstructorTest()
        {
            try
            {
                double[] sides;
                sides = new double[] { 4, 5, 6 };
                new Triangle(sides);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }

    }
}