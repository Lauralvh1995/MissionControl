using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Mission
    {
        string Name { get; }
        DateTime LaunchDate { get; }
        DateTime ReturnDate { get; }
        string SpaceShip { get; }

        List<Astronaut> astronauts;

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceShip)
        {
            Name = name;
            LaunchDate = launchDate;
            ReturnDate = returnDate;
            SpaceShip = spaceShip;
            astronauts = new List<Astronaut>();
        }

        public bool AddAstronautToMission(Astronaut astronaut)
        {
            foreach(Astronaut astr in astronauts)
            {
                if(astr.GetName() == astronaut.GetName())
                {
                    return false;
                }
            }
            astronauts.Add(astronaut);
            return true;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return Name + " - Launch Date: " + LaunchDate.ToShortDateString() + " - Return Date: " + ReturnDate.ToShortDateString() + " - Space Ship: " + SpaceShip;
        }
    }
}
