using System.Collections.Generic;

namespace TDDDemo
{
	public interface IPrimeFactor
	{
		List<int> GetResult(int value);
		void Calculate();
	}
}
