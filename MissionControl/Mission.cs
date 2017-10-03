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
        public int MissionLenght { get; }

        List<Astronaut> astronauts;


        public Mission(string name, DateTime launchDate, DateTime returnDate, string spaceShip)
        {
            Name = name;
            LaunchDate = launchDate;
            ReturnDate = returnDate;
            SpaceShip = spaceShip;
            astronauts = new List<Astronaut>();

            MissionLenght = (int)((ReturnDate.Ticks - LaunchDate.Ticks)/(10000000L * 3600L * 24L));
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
            if(LaunchDate > other.LaunchDate || MissionLenght > other.MissionLenght)
            {
                return 1;
            }
            else if(LaunchDate == other.LaunchDate || MissionLenght == other.MissionLenght)
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
            return MissionLenght;
        }
    }
}
