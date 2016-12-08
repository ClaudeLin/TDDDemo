using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo;

namespace TDDDemoTest
{
	[TestClass]
	public class LeapYearsTest
	{
		LeapYears ly = new LeapYears();
		private int year;
		private bool actual;

		[TestMethod]
		public void TestAD1()
		{
			year = 1;
			actual = ly.IsLeapYear(year);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void TestAD2()
		{
			year = 2;
			actual = ly.IsLeapYear(year);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void TestAD4()
		{
			year = 4;
			actual = ly.IsLeapYear(year);

			Assert.IsTrue(actual);
		}

		[TestMethod]
		public void TestAD8()
		{
			year = 8;
			actual = ly.IsLeapYear(year);

			Assert.IsTrue(actual);
		}

		[TestMethod]
		public void TestAD100()
		{
			year = 100;
			actual = ly.IsLeapYear(year);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void TestAD200()
		{
			year = 200;
			actual = ly.IsLeapYear(year);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void TestAD400()
		{
			year = 400;
			actual = ly.IsLeapYear(year);

			Assert.IsTrue(actual);
		}

		[TestMethod]
		public void TestAD2000()
		{
			year = 2000;
			actual = ly.IsLeapYear(year);

			Assert.IsTrue(actual);
		}

		[TestMethod]
		public void TestAD2100()
		{
			year = 2100;
			actual = ly.IsLeapYear(year);

			Assert.IsFalse(actual);
		}
	}
}
