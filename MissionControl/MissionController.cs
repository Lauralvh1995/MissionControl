using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissionControl
{
    public class MissionController
    {
        List<Mission> missions;
        List<Astronaut> possibleAstronauts;

        public MissionController()
        {
            missions = new List<Mission>();
            possibleAstronauts = new List<Astronaut>();
        }

        public void SortMissions()
        {
            missions.Sort();
        }

        public bool AddMission(Mission mission)
        {
            foreach (Mission checkMission in missions)
            {
                if (checkMission.GetName() == mission.GetName())
                {
                    return false;
                }
            }
            missions.Add(mission);
            return true;
        }

        public List<string> GetMissionHistoryString(Astronaut astronaut)
        {
            List<string> missionNames = new List<string>();
            foreach(Mission mission in missions)
            {
                if(mission.GetAstronauts().Contains(astronaut))
                {
                    missionNames.Add(mission.GetName());
                }
            }
            return missionNames;
        }

        public List<Mission> GetMissionHistory(Astronaut astronaut)
        {
            List<Mission> missionNames = new List<Mission>();
            foreach (Mission mission in missions)
            {
                if (mission.GetAstronauts().Contains(astronaut))
                {
                    missionNames.Add(mission);
                }
            }
            return missionNames;
        }

        public List<string> GetTravelCompanions(Astronaut astronaut)
        {
            throw new NotImplementedException();
        }

        public int GetTotalDaysInSpace(Astronaut astronaut)
        {
            int totalDays = 0;
            List<Mission> tempMissions = new List<Mission>();
            foreach (Mission mission in missions)
            {
                if (mission.GetAstronauts().Contains(astronaut))
                {
                    tempMissions.Add(mission);
                }
            }

            foreach(Mission mission in tempMissions)
            {
                totalDays += mission.GetMissionLenght();
            }
            return totalDays;
        }

        public Mission GetLongestMission(Astronaut astronaut)
        {
            List<Mission> temp = GetMissionHistory(astronaut).OrderBy(mission => mission.GetMissionLenght()).ToList();

            return temp.First();
        }

        public Astronaut GetAstronautByName(string name)
        {
            foreach (Astronaut astronaut in possibleAstronauts)
            {
                if (astronaut.GetName() == name)
                {
                    return astronaut;
                }
            }
            return null;
        }

        public Mission GetMissionByName(string name)
        {
            foreach (Mission mission in missions)
            {
                if (mission.GetName() == name)
                {
                    return mission;
                }
            }
            return null;
        }

        public bool AddAstronaut(Astronaut astronaut)
        {
            foreach (Astronaut checkAstronaut in possibleAstronauts)
            {
                if (checkAstronaut.GetName() == astronaut.GetName())
                {
                    return false;
                }
            }
            possibleAstronauts.Add(astronaut);
            return true;
        }
    }
}
