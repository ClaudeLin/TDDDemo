using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
	public class StringCalculator
	{
		public int Calculate(string inputString)
		{
			return Convert.ToInt32(new DataTable().Compute(inputString, null));
		}
	}
}
