using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissionControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl.Tests
{
    [TestClass()]
    public class MissionControllerTests
    {
        MissionController mControl = new MissionController();
        Mission mission1 = new Mission("Apollo 11", new DateTime(1969, 7, 16), new DateTime(1969, 7, 24), "CSM Columbia - LM Eagle");
        Astronaut astronaut1 = new Astronaut("Neil Armstrong", "Male", "American");

        [TestMethod()]
        public void AddMissionTest()
        {
            Assert.AreEqual(true, mControl.AddMission(mission1));
            Assert.AreEqual(false, mControl.AddMission(mission1));
        }

        [TestMethod()]
        public void GetMissionHistoryStringTest()
        {
            mission1.AddAstronautToMission(astronaut1);

            Assert.AreEqual(mControl.GetMissionHistoryString(astronaut1).First(), mission1.GetName(), "GetMissionHistory");
        }

        [TestMethod()]
        public void GetMissionByNameTest()
        {
            mControl.AddMission(mission1);
            Assert.AreEqual(mission1, mControl.GetMissionByName("Apollo 11"));
        }

        [TestMethod()]
        public void GetAstronautByNameTest()
        {
            mControl.AddAstronaut(astronaut1);
            Assert.AreEqual(astronaut1, mControl.GetAstronautByName("Neil Armstrong"));
        }

        [TestMethod()]
        public void GetLongestMissionTest()
        {
            mission1.AddAstronautToMission(astronaut1);
            Assert.AreEqual("Apollo 11", mControl.GetLongestMission(astronaut1).GetName());
        }

        [TestMethod()]
        public void GetTotalDaysInSpaceTest()
        {
            mission1.AddAstronautToMission(astronaut1);
            Assert.AreEqual(8, mControl.GetTotalDaysInSpace(astronaut1));
        }

        [TestMethod()]
        public void GetTravelCompanionsTest()
        {
            Assert.Fail();
        }
    }
}