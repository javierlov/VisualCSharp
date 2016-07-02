
namespace Indexers
{
	struct Name
	{
		public Name(string text)
		{
			name = text;
		}

		public string Text
		{
			get { return name; }
		}

		public override int GetHashCode()
		{
			return name.GetHashCode();
		}

		public override bool Equals(object other)
		{
			return (other is Name) && Equals((Name)other);
		}
		
		public bool Equals(Name other)
		{
			return name == other.name;
		}

		private string name;
	}
}