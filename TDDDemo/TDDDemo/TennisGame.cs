using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
	public class TennisGame
	{
		private int _serveScore = 0;
		private string[] _scoreName = new string[] { "Love", "Fifteen", "Thirty", "Forty", "Advantage" };
		private int _receiverScore = 0;

		public string GetGameScore()
		{
			if (_serveScore == _receiverScore)
			{
				if (_serveScore == 3)
				{
					return "Deuce";
				}
				return _scoreName[_serveScore] + " All";
			}
			if (_serveScore == 4 && _receiverScore == 3)
			{
				return _scoreName[_serveScore] + " Serve";
			}
			return _scoreName[_serveScore] + " " + _scoreName[_receiverScore];
		}

		public void ServeGetScore()
		{
			_serveScore += 1;
		}

		public void ServeGetScore(int count)
		{
			_serveScore += count;
		}

		public void ReceiverGetScore()
		{
			_receiverScore += 1;
		}

		public void ReceiverGetScore(int count)
		{
			_receiverScore += count;
		}
	}
}
