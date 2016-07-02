namespace CSharp
{
	abstract class DefaultTokenImpl
	{
		new public string ToString()
		{
			return name;
		}
		protected DefaultTokenImpl(string name)
		{
			this.name = name;
		}
		private readonly string name;
	}
}
