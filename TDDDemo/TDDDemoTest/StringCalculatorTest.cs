using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo;

namespace TDDDemoTest
{
	[TestClass]
	public class StringCalculatorTest
	{
		private int expect;
		private string inputString;
		private int actual;
		StringCalculator sc = new StringCalculator();
		[TestMethod]
		public void Test_One_Plus_One()
		{
			expect = 2;
			inputString = "1+1";
			
			actual=sc.Calculate(inputString);

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Two_Plus_One()
		{
			expect = 3;
			inputString = "2+1";
			
			actual = sc.Calculate(inputString);

			Assert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Five_Minus_One()
		{
			expect = 4;
			inputString = "5-1";

			actual = sc.Calculate(inputString);

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Two_Multiplied_Five()
		{
			expect = 10;
			inputString = "2*5";

			actual = sc.Calculate(inputString);

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Eighteen_Division_Three()
		{
			expect = 6;
			inputString = "18/3";

			actual = sc.Calculate(inputString);

			Assert.AreEqual(expect,actual);
		}
	}
}
