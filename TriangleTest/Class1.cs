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
            //Unit Test 1 for Scalene Trinagle 
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
            //Unit Test 2 for Scalene Trinagle 
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
            //Unit Test 3 for Scalene Trinagle 
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
            //Unit Test 4 for Scalene Trinagle 
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
            //Unit Test 4 for Scalene Trinagle
            int side1 = 11;
            int side2 = 14;
            int side3 = 16;



            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_OnesSideZero()
        {
            // Unit test for Triangle where One Side is Zero
            int side1 = 11;
            int side2 = 0;
            int side3 = 18;



            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_TwoSideZero()
        {
            // Unit test for Triangle where Two Side is Zero
            int side1 = 11;
            int side2 = 0;
            int side3 = 0;



            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_AllThresSideZero()
        {
            // Unit test for Triangle where All Three Side is Zero
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;



            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_SumofTwoisLessthanThirdSide()
        {
            //Unit Test for Triangle Where Sum of two side is Less than Thrid Side
            int side1 = 2;
            int side2 = 3;
            int side3 = 8;



            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_SumofTwoisEqualtoThirdSide()
        {
            //Unit Test for Triangle Where Sum of two side is Equal to Thrid Side
            int side1 = 2;
            int side2 = 3;
            int side3 = 5;



            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Validtriangle_ValidInput_SideareNegative()
        {
            //Unit Test for triangle where side are Negative
            int side1 = 5;
            int side2 = -3;
            int side3 = -9;



            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
        }



    }
}
