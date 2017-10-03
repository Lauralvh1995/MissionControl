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
            Assert.AreEqual(mControl.AddMission(mission1), true);
            Assert.AreEqual(mControl.AddMission(mission1), false);
        }

        [TestMethod()]
        public void GetMissionHistoryTest()
        {
            mission1.AddAstronautToMission(astronaut1);

            Assert.AreEqual(mControl.GetMissionHistory(astronaut1), mission1.GetName(), "GetMissionHistory");
        }

        [TestMethod()]
        public void GetMissionByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAstronautByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetLongestMissionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTotalDaysInSpaceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTravelCompanionsTest()
        {
            Assert.Fail();
        }
    }
}