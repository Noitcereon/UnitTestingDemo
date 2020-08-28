using System;
using System.Collections.Generic;
using System.Text;
using StudentLib.Interfaces;

namespace StudentLib
{

    public class Student : PersonBase
    {
        #region Backing Fields
        private int _semester;
        #endregion

        #region Constructors
        public Student(string name, string address, GenderType gender) : base(name, address, gender)
        { }
        public Student(string name, string address, int semester, GenderType gender) : base(name, address, gender)
        {
            Semester = semester;
        }
        #endregion

        #region Properties
        public int Semester
        {
            get => _semester;
            set
            {
                if (value >= 1 && value <= 8) _semester = value;

                else { throw new ArgumentOutOfRangeException(); }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name}, {Address}, {Semester}, {Gender}";
        }
        #endregion

      
    }
}
