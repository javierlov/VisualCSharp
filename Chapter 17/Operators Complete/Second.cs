
namespace Operators
{
	struct Second
	{
		public Second(int initialValue)
		{
			value = System.Math.Abs(initialValue) % 60;
		}

		public int Value
		{
			get { return value; }
		}

		public static implicit operator Second (int arg)
		{
			return new Second(arg);
		}

		public static bool operator==(Second lhs, Second rhs)
		{
			return lhs.value == rhs.value;
		}

		public static bool operator!=(Second lhs, Second rhs)
		{
			return lhs.value != rhs.value;
		}

		public override bool Equals(object other)
		{
			return (other is Second) && Equals((Second)other);
		}

		public bool Equals(Second other)
		{
			return value == other.value;
		}

		public override int GetHashCode()
		{
			return value;
		}

		public static Second operator++(Second arg)
		{
			arg.value++;
			if (arg.value == 60)
			{
				arg.value = 0;
			}
			return arg;
		}

		private int value;
	}
}
