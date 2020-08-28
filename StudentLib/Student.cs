using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLib
{
    public enum GenderType { Male, Female, Other }

    public class Student
    {
        #region Backing Fields
        private string _name;
        private string _address;
        private int _semester;
        #endregion

        #region Constructors
        public Student(string name, string address, int semester, GenderType gender)
        {
            Name = name;
            Address = address;
            Semester = semester;
            Gender = gender;
        }

        public Student(string name, string address)
        {
            Name = name;
            Address = address;
            Semester = 1;
            Gender = GenderType.Male;
        }
        #endregion

        #region Properties
        public String Name
        {
            get => _name;
            set
            {
                if (value.Length <= 1) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        public String Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException();
        }

        public int Semester
        {
            get => _semester;
            set
            {
                if (value >= 1 && value <= 8) _semester = value;

                else { throw new ArgumentOutOfRangeException(); }
            }
        }
        public GenderType Gender { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name}, {Address}, {Semester}, {Gender}";
        }
        #endregion
    }
}
