using System;
using StudentLib;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Thomas", "Hedeboparken 4");
            Console.WriteLine(student);

            Console.ReadKey();
        }
    }
}
