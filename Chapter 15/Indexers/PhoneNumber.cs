
namespace Indexers
{
	struct PhoneNumber
	{
		public PhoneNumber(string text)
		{
			number = text;
		}

		public string Text
		{
			get { return number; }
		}

		public override int GetHashCode()
		{
			return number.GetHashCode();
		}

		public override bool Equals(object other)
		{
			return (other is PhoneNumber) && Equals((PhoneNumber)other);
		}
		
		public bool Equals(PhoneNumber other)
		{
			return number == other.number;
		}

		private string number;
	}
}
