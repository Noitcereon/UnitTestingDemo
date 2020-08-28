using System;
using StudentLib;
using StudentLib.Interfaces;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson student = new Student("Thomas", "Hedeboparken 4", GenderType.Male);
            Console.WriteLine(student);

            Console.ReadKey();
        }
    }
}
