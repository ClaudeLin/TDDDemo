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
		private string[] _scoreName = new string[] { "Love", "Fifteen", "Thirty", "Forty" ,"Win"};
		private int _receiverScore = 0;
		private string _serveName = "Serve";
		private string _receiverName = "Receiver";
		private string _gameResult = "";

		public string GetGameScore()
		{
			if (CheckWin())
			{
				return _gameResult;
			}

			if (_serveScore == _receiverScore)
			{
				if (_serveScore == 3)
				{
					return "Deuce";
				}
				else
				{
					return _scoreName[_serveScore] + " All";
				}
			}

			if (CheckServeAdv() || CheckReceiverAdv())
			{
				return _gameResult;
			}
			
			return _scoreName[_serveScore] + " " + _scoreName[_receiverScore];
		}

		private bool CheckWin()
		{
			if (_serveScore >= 4 && (_serveScore-_receiverScore)>1)
			{
				_gameResult = _serveName+" "+_scoreName[4];
				return true; 
			}
			if ((_receiverScore-_serveScore) >1 && _receiverScore >= 4)
			{
				_gameResult = _receiverName + " " + _scoreName[4];
				return true;
			}
			return false;
		}

		public void ServeGetScore()
		{
			if (CheckReceiverAdv())
			{
				_receiverScore -= 1;
				return;
			}

			_serveScore += 1;
		}

		public void ServeGetScore(int count)
		{
			if (CheckReceiverAdv())
			{
				_receiverScore -= 1;
				return;
			}

			_serveScore += count;
		}

		private bool CheckReceiverAdv()
		{
			if (_serveScore == 3 && _receiverScore == 4)
			{
				_gameResult = "Advantage " + _receiverName;
				return true;
			}

			return false;
		}

		public void ReceiverGetScore()
		{
			if (CheckServeAdv())
			{
				_serveScore -= 1;
				return;
			}

			_receiverScore += 1;
		}

		public void ReceiverGetScore(int count)
		{
			if (CheckServeAdv())
			{
				_serveScore -= 1;
				return;
			}
			_receiverScore += count;
		}

		private bool CheckServeAdv()
		{
			if (_serveScore == 4 && _receiverScore == 3)
			{
				_gameResult = "Advantage " + _serveName;
				return true;
			}

			return false;
		}
	}
}
