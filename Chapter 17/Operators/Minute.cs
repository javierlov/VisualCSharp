
namespace Operators
{
	struct Minute
	{
		public Minute(int initialValue)
		{
			value = System.Math.Abs(initialValue) % 60;
		}

		public int Value
		{
			get { return value; }
		}

		// add operator==(Minute, int) here
        public static bool operator==(Minute lhs, int rhs)
        {
            return lhs.value == rhs;
        }

		// add operator!=(Minute, int) here
        public static bool operator !=(Minute lhs, int rhs)
        {
            return lhs.value != rhs;
        }

		public override bool Equals(object other)
		{
			return (other is Minute) && Equals((Minute)other);
		}

		public bool Equals(Minute other)
		{
			return value == other.value;
		}

		public override int GetHashCode()
		{
			return value;
		}

		
        public static Minute operator++(Minute arg)
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
