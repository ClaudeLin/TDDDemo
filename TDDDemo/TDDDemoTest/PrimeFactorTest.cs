using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDDDemo;

namespace TDDDemoTest
{
	[TestClass]
	public class PrimeFactorTest
	{
		private List<int> expect=new List<int>();
		private List<int> actual;
		private int inputNum = 1;
		private PrimeFactor pf= new PrimeFactor();

		[TestMethod]
		public void Test_One()
		{
			inputNum = 1;

			actual = pf.GetResult(inputNum);
			CollectionAssert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Two()
		{
			expect.Add(2);
			inputNum = 2;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Three()
		{
			expect.Add(3);
			inputNum = 3;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Four()
		{
			expect.Add(2);
			expect.Add(2);
			inputNum = 4;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Five()
		{
			expect.Add(5);
			inputNum = 5;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_Six()
		{
			expect.Add(2);
			expect.Add(3);
			inputNum = 6;

			actual = pf.GetResult(inputNum);
			
			CollectionAssert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Seven()
		{
			expect.Add(7);
			inputNum = 7;
			
			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Eight()
		{
			expect.Add(2);
			expect.Add(2);
			expect.Add(2);
			inputNum = 8;
			
			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Nine()
		{
			expect.Add(3);
			expect.Add(3);
			inputNum = 9;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}
		
		[TestMethod]
		public void Test_LargeNum()
		{
			expect.Add(7);
			expect.Add(23);
			expect.Add(29);
			expect.Add(283);
			inputNum = 1321327;
	
			var mock = new Mock<PrimeFactorCounter>()
			{
				CallBase = true
			};

			actual = mock.Object.GetResult(inputNum);
			//actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}
		[Ignore]
		[TestMethod]
		public void Test_MaxInt()
		{
			expect.Add(int.MaxValue);
			
			inputNum = int.MaxValue;

			actual = pf.GetResult(inputNum);

			CollectionAssert.AreEqual(expect, actual);
		}
	}
}
