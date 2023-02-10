using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class Class1:Triangle
    {
        [Test]
        public void ValidTriangle_Input5and5and5_OutputValidEquilateralTrinagle()
        {

            //  All sides are same for  Equilateral Triangle 

            int side1 = 5;
            int side2 = 5;
            int side3 = 5;



            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidTriangle_Input6and6and4_OutputValidIsosceles()
        {
            // First and Second Side are same and third side is different for Isosceles triangle 

            int side1 = 6;
            int side2 = 6;
            int side3 = 4;



            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidTriangle_Input4and6and6_OutputValidIsosceles()
        {
            // Second and Third Side are same and First side is different for Isosceles triangle 


            int side1 = 4;
            int side2 = 6;
            int side3 = 6;



            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidTriangle_Input6and4and6_OutputValidIsosceles()
        {
            // First and Third Side are same and Second side is different for Isosceles triangle 


            int side1 = 6;
            int side2 = 4;
            int side3 = 6;



            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScalenetriangle_ValidInput_AllDifferentNumber1()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidScalenetriangle_ValidInput_AllDifferentNumber2()
        {
            int side1 = 300;
            int side2 = 400;
            int side3 = 500;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidScalenetriangle_ValidInput_AllDifferentNumber3()
        {
            int side1 = 7;
            int side2 = 24;
            int side3 = 25;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidScalenetriangle_ValidInput_AllDifferentNumber4()
        {
            int side1 = 20;
            int side2 = 21;
            int side3 = 22;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidScalenetriangle_ValidInput_AllDifferentNumber5()
        {
            int side1 = 11;
            int side2 = 14;
            int side3 = 16;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_OneLengthZero()
        {
            int side1 = 11;
            int side2 = 14;
            int side3 = 16;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
       
    }
}
