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
        private Student _student;

        [TestInitialize]
        public void Init()
        {
            _student = new Student("Thomas", "Hedeboparken 4", 3, GenderType.Male);
        }

        [TestMethod()]
        public void StudentNameTest()
        {
            Assert.AreEqual("Thomas", _student.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Name = "Y");
            Assert.AreEqual("Thomas", _student.Name);
        }

        [TestMethod]
        public void StudentAddressTest()
        {
            Assert.AreEqual("Hedeboparken 4", _student.Address);
            Assert.ThrowsException<ArgumentNullException>(() => _student.Address = null);
            Assert.AreEqual("Hedeboparken 4", _student.Address);
        }
        [TestMethod]
        public void StudentSemesterTest()
        {
            Assert.AreEqual(3, _student.Semester);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 0);
            Assert.AreEqual(3, _student.Semester);
        }
        [TestMethod]
        public void StudentGenderTest()
        {
            Assert.AreEqual(GenderType.Male, _student.Gender);
        }
    }
}