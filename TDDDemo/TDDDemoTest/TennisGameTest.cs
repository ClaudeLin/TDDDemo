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
	public class TennisGameTest
	{
		private string expect;
		private string actual;
		TennisGame tg = new TennisGame();

		[TestMethod]
		public void Test_LoveAll()
		{
			expect = "Love All";
			
			actual = tg.GetGameScore();

			Assert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_FifteenLove()
		{
			expect = "Fifteen Love";
			
			tg.ServeGetScore();
			actual = tg.GetGameScore();

			Assert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_ThirtyLove()
		{
			expect = "Thirty Love";
			
			tg.ServeGetScore(2);
			actual = tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_FortyLove()
		{
			expect = "Forty Love";
			tg.ServeGetScore(3);
			actual = tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_FifteenAll()
		{
			expect = "Fifteen All";

			tg.ServeGetScore(1);
			tg.ReceiverGetScore(1);
			actual = tg.GetGameScore();
			
			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_LoveFifteen()
		{
			expect = "Love Fifteen";

			tg.ReceiverGetScore();
			actual=tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_FortyThirty()
		{
			expect = "Forty Thirty";

			tg.ServeGetScore(3);
			tg.ReceiverGetScore(2);
			actual = tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}

		[TestMethod]
		public void Test_FifteenForty()
		{
			expect = "Fifteen Forty";

			tg.ServeGetScore(1);
			tg.ReceiverGetScore(3);
			actual = tg.GetGameScore();

			Assert.AreEqual(expect, actual);
		}

		[TestMethod]
		public void Test_Deuce()
		{
			expect = "Deuce";

			tg.ServeGetScore(3);
			tg.ReceiverGetScore(3);
			actual = tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}


		[TestMethod]
		public void Test_AdvantageServe()
		{
			expect = "Advantage Serve";

			tg.ServeGetScore(3);
			tg.ReceiverGetScore(3);
			tg.ServeGetScore();
			actual = tg.GetGameScore();

			Assert.AreEqual(expect,actual);
		}
	}
}
