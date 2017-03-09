using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo;

namespace TDDDemoTest
{
    [TestClass]
    public class OneHundredDoorsTest
    {
        private OneHundredDoors doors;

	    [TestInitialize]
	    public void TestInit()
	    {
		    doors=new OneHundredDoors();
	    }

        [TestMethod]
        public void TestVisitOneTime()
        {
            doors.Visit();
			Assert.IsTrue(doors.GetDoorStatus());
        }

        [TestMethod]
        public void TestVisitTwoTimes()
        {
            doors.Visit(2);

			Assert.IsFalse(doors.GetDoorStatus());
        }

        [TestMethod]
        public void TestVisitThreeTimes()
        {
            doors.Visit(3);

			Assert.IsFalse(doors.GetDoorStatus());
        }

        [TestMethod]
        public void TestVisitFourTimes()
        {
            doors.Visit(4);

			Assert.IsTrue(doors.GetDoorStatus());
        }

        [TestMethod]
        public void TestVisit100Times()
        {
            doors.Visit(100);

			Assert.IsTrue(doors.GetDoorStatus());
        }

        [TestMethod]
        public void TestVisit50thDoorWith100Times()
        {
            doors.Visit(100);

			Assert.IsFalse(doors.GetDoorStatus(50));
        }

        [TestMethod]
        public void Test1000Doors()
        {
            doors = new OneHundredDoors(1000);
            doors.Visit(1000);

			Assert.IsFalse(doors.GetDoorStatus(1000));
        }
    }
}
