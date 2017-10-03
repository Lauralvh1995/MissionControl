using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    class Astronaut
    {
        string Name { get; }
        string Gender { get; }
        string Nationality { get; }

        public Astronaut(string name, string gender, string nationality)
        {
            Name = name;
            Gender = gender;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return Name + " " + Gender + " " + Nationality;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
