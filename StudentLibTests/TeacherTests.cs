using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentLib;

namespace StudentLibTests
{
    [TestClass]
    public class TeacherTests
    {
        private Teacher _teacher;
        [TestInitialize]
        public void Init()
        {
            _teacher = new Teacher("Kari", "Göteborggatan 351", GenderType.Female);
        }

        [TestMethod]
        public void SalaryTest()
        {
            Assert.AreEqual(0, _teacher.Salary);

            _teacher.Salary = 100;
            Assert.AreEqual(100, _teacher.Salary);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _teacher.Salary = -1);
        }
    }
}
