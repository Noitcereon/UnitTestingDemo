using System;
using System.Collections.Generic;
using System.Text;
using StudentLib.Interfaces;

namespace StudentLib
{
    public class Teacher : PersonBase
    {
        private int _salary;

        public Teacher(string name, string address, GenderType gender) : base(name, address, gender)
        {
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _salary = value;
            } 
        }

   
    }
}
