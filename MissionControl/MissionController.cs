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

        public List<string> GetMissionHistory(Astronaut astronaut)
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

        public string GetLongestMission(Astronaut astronaut)
        {
            throw new NotImplementedException();
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
    }
}
