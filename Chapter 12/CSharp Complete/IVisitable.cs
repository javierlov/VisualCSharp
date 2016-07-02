namespace CSharp
{
	interface IVisitable
	{
		void Accept(ITokenVisitor visitor);
	}
}
