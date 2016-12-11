using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo;

namespace TDDDemoTest
{
    [TestClass]
    public class OneHundredDoorsTest
    {
        private OneHundredDoors doors;
        private bool actual;
        [TestMethod]
        public void TestVisitOneTime()
        {
            doors = new OneHundredDoors();
            doors.Visit();

            actual = doors.GetDoorStatus();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestVisitTwoTimes()
        {
            doors = new OneHundredDoors();
            doors.Visit(2);


            actual = doors.GetDoorStatus();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestVisitThreeTimes()
        {
            doors = new OneHundredDoors();
            doors.Visit(3);


            actual = doors.GetDoorStatus();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestVisitFourTimes()
        {
            doors = new OneHundredDoors();
            doors.Visit(4);


            actual = doors.GetDoorStatus();

            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void TestVisit100Times()
        {
            doors = new OneHundredDoors();
            doors.Visit(100);


            actual = doors.GetDoorStatus();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestVisit50thDoorWith100Times()
        {
            doors = new OneHundredDoors();
            doors.Visit(100);

            actual = doors.GetDoorStatus(50);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test1000Doors()
        {
            doors = new OneHundredDoors(1000);
            doors.Visit(1000);

            actual = doors.GetDoorStatus(1000);

            Assert.IsFalse(actual);
        }
    }
}
