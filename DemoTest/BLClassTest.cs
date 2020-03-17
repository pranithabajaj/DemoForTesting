using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class BLClassTest
    {
        [TestMethod]
        public void DivideTest1()
        {
            //Arrange -Declare actuals and expected
            int Numerator = 10;
            int Denominator = 2;
            int expected = 5;
            int actual = 0;

            //Act     -call the method and pass the actuals as parameters
            BLClass B = new BLClass();
            actual = B.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert  -check whether actuals are matching with expected
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest2()
        {
            int Numerator = 0;
            int Denominator = 2;
            int expected = 0;
            

            //Act     -call the method and pass the actuals as parameters
            BLClass B = new BLClass();
            int actual = B.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert  -check whether actuals are matching with expected
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest3()
        {
            int Numerator = 10;
            int Denominator = 0;
            BLClass B = new BLClass();
            var ex = Assert.ThrowsException<DivideByZeroException>(()=>B.Divide(Numerator.ToString(),Denominator.ToString()));
            Assert.AreEqual("Cannot divide by zero",ex.Message);
        }
        [TestMethod]
        public void DivideTest4()
        {
            
            BLClass B = new BLClass();
            var ex = Assert.ThrowsException<FormatException>(() => B.Divide("abc","xyz"));
            Assert.AreEqual("Only Numbers", ex.Message);
        }
    }
}
