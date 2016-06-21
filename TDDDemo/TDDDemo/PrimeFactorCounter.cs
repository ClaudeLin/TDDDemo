using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
	public class PrimeFactorCounter : PrimeFactor
	{
		public int count = 0;
		override  public void Calculate()
		{
			count++;
			base.Calculate();
		}
	}
}
