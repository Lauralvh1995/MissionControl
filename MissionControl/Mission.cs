using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class Mission : IComparable<Mission>
    {
        string Name { get; }
        DateTime LaunchDate { get; }
        DateTime ReturnDate { get; }
        string SpaceShip { get; }

        List<Astronaut> astronauts;
        private int missionLenght;

        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceShip)
        {
            Name = name;
            LaunchDate = launchDate;
            ReturnDate = returnDate;
            SpaceShip = spaceShip;
            astronauts = new List<Astronaut>();

            missionLenght = Convert.ToInt32(ReturnDate.Date - LaunchDate.Date);
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

        public int CompareTo(Mission other)
        {
            if(LaunchDate > other.LaunchDate)
            {
                return 1;
            }
            else if(LaunchDate == other.LaunchDate)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public IReadOnlyList<Astronaut> GetAstronauts()
        {
            return astronauts.AsReadOnly();
        }
        public int GetMissionLenght()
        {
            return missionLenght;
        }
    }
}
