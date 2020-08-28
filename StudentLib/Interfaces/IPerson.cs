using System;

namespace StudentLib.Interfaces
{
    public interface IPerson
    {
        String Name { get; set; }
        String Address { get; set; }
        GenderType Gender { get; set; }
    }
}