using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibTests
{
    [TestClass()]
    public class StudentTests
    {
        readonly Student student = new Student("Thomas", "Hedeboparken 4", 3, GenderType.Male);

        [TestMethod()]
        public void StudentNameTest()
        {
            Assert.AreEqual("Thomas", student.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.Name = "Y");
            Assert.AreEqual("Thomas", student.Name);
        }

        [TestMethod]
        public void StudentAddressTest()
        {
            Assert.AreEqual("Hedeboparken 4", student.Address);
            Assert.ThrowsException<ArgumentNullException>(() => student.Address = null);
            Assert.AreEqual("Hedeboparken 4", student.Address);
        }
        [TestMethod]
        public void StudentSemesterTest()
        {
            Assert.AreEqual(3, student.Semester);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.Semester = 9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.Semester = 0);
            Assert.AreEqual(3, student.Semester);
        }
        [TestMethod]
        public void StudentGenderTest()
        {
            Assert.AreEqual(GenderType.Male, student.Gender);
        }
    }
}