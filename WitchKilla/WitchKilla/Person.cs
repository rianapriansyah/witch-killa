using System;
using System.Collections.Generic;
using System.Text;

namespace WitchKilla
{
    public class Person
    {
        public int AgeOfDeath { get; set; }
        public int YearOfDeath { get; set; }

        public int YearOfBirth => YearOfDeath - AgeOfDeath;
    }
}
