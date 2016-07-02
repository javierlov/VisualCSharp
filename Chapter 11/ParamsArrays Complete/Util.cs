
namespace ParamsArrays
{
	using System;

	class Util
	{
		public static int Min(params int[] array)
		{
			if (array == null)
			{
				throw new ArgumentException("Util.Min: null array");
			}

			if (array.Length == 0)
			{
				throw new ArgumentException("Util.Min: empty array");
			}

			int currentMin = array[0];
			foreach (int i in array)
			{
				currentMin = Min(currentMin, i);
			}
			return currentMin;
		}

		public static int Min(int lhs, int rhs)
		{
			return lhs < rhs ? lhs : rhs;
		}
	}
}