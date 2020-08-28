using System;
using StudentLib.Interfaces;

namespace StudentLib
{
    public enum GenderType { Male, Female, Other }

    public abstract class PersonBase : IPerson
    {
        private string _name;
        private string _address;

        protected PersonBase(string name, string address, GenderType gender)
        {
            Name = name;
            Address = address;
            Gender = gender;
        }

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

        public GenderType Gender { get; set; }
    }
}