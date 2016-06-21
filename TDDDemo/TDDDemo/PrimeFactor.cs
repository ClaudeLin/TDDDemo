using System.Collections.Generic;

namespace TDDDemo
{
	public class PrimeFactor : IPrimeFactor
	{

		private List<int> result = new List<int>();
		private int divisor = 2;
		private int _value;

		public List<int> GetResult(int value)
		{
			_value = value;
			while (_value >= divisor)
			{
				Calculate();

			}
			return result;
		}

		public virtual void Calculate()
		{
			if (_value % divisor == 0)
			{
				result.Add(divisor);

				_value = _value / divisor;
			}
			else
			{
				divisor++;
			}
		}
	}
}
