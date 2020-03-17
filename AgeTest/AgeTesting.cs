using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeTest
{
    [TestClass]
    public class AgeTesting
    {
        [TestMethod]
        public void AgeTest1()
        {
            DateTime Dob = DateTime.Parse("10-28-1997");
            string expected = "22";
            string actual;
            BLClass B = new BLClass();
            actual = B.Age(Dob);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AgeTest2()
        {
            DateTime Dob = DateTime.Parse("10-28-2003");
            BLClass B = new BLClass();
            var ex = Assert.ThrowsException<CustomException>(() => B.Age(Dob));
            Assert.AreEqual("Age should be greater than 16", ex.Message);
        }
        [TestMethod]
        public void AgeTest3()
        {
            DateTime Dob = DateTime.Parse("10-28-1947");
            BLClass B = new BLClass();
            var ex = Assert.ThrowsException<CustomException>(() => B.Age(Dob));
            Assert.AreEqual("Age should be less than 60", ex.Message);
        }
    }
}
