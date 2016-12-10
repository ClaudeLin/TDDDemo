using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            doors =new OneHundredDoors();
            doors.Visit();

            actual = doors.GetLastDoorStatus();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestVisitTwoTimes()
        {
            doors=new OneHundredDoors();
            doors.Visit(2);
            

            actual = doors.GetLastDoorStatus();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestVisitThreeTimes()
        {
            doors = new OneHundredDoors();
            doors.Visit(3);
           

            actual = doors.GetLastDoorStatus();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestVisitFourTimes()
        {
            doors = new OneHundredDoors();
            doors.Visit(4);


            actual = doors.GetLastDoorStatus();

            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void TestVisit100Times()
        {
            doors = new OneHundredDoors();
            doors.Visit(100);


            actual = doors.GetLastDoorStatus();

            Assert.IsTrue(actual);
        }

    }
}
