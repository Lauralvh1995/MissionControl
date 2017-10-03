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
    public class MissionTests
    {
        [TestMethod()]
        public void AddAstronautToMissionTest()
        {
            Mission mission1 = new Mission("Apollo 11", new DateTime(1969, 7, 16), new DateTime(1969, 7, 24), "CSM Columbia - LM Eagle");

            Assert.AreEqual(true, mission1.AddAstronautToMission(new Astronaut("Neil Armstrong", "Male", "American")));
            Assert.AreEqual(false, mission1.AddAstronautToMission(new Astronaut("Neil Armstrong", "Male", "American")));
        }
    }
}