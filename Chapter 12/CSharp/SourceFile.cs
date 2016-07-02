    namespace CSharp
{
	class SourceFile : IVisitable
	{
        public void Accept(ITokenVisitor visitor)
        {
            foreach(IVisitableToken token in tokens)
            {
                token.Accept(visitor);
            }
        }

		private IVisitableToken[] tokens =
		{
            new KeywordToken("using"),
            new WhitespaceToken(" "),
            new IdentifierToken("System"),
            new PunctuatorToken(";"),
            new WhitespaceToken("\n"),
            new WhitespaceToken("\n"),
			new KeywordToken("class"),
			new WhitespaceToken(" "),
			new IdentifierToken("Greeting"),
			new WhitespaceToken("\n"),
			new PunctuatorToken("{"),
			new WhitespaceToken("\n"),
			new WhitespaceToken("    "),
			new KeywordToken("static"),
			new WhitespaceToken(" "),
			new KeywordToken("void"),
			new WhitespaceToken(" "),
			new IdentifierToken("Main"),
			new PunctuatorToken("("),
			new PunctuatorToken(")"),
			new WhitespaceToken("\n"),
			new WhitespaceToken("    "),
			new PunctuatorToken("{"),
			new WhitespaceToken("\n"),
			new WhitespaceToken("        "),
			new IdentifierToken("Console"),
			new OperatorToken("."),
			new IdentifierToken("WriteLine"),
			new PunctuatorToken("("),
			new StringLiteralToken("\"Hello, world\""),
			new PunctuatorToken(")"),
			new PunctuatorToken(";"),
			new WhitespaceToken("\n"),
			new WhitespaceToken("    "),
			new PunctuatorToken("}"),
			new WhitespaceToken("\n"),
			new PunctuatorToken("}"),
		};
	}

	class IdentifierToken : DefaultTokenImpl, IVisitableToken
	{
		public IdentifierToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitIdentifier(ToString());
		}
	}

	class KeywordToken : DefaultTokenImpl, IVisitableToken
	{
		public KeywordToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitKeyword(ToString());
		}
	}

	class WhitespaceToken : DefaultTokenImpl, IVisitableToken
	{
		public WhitespaceToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitWhitespace(ToString());
		}
	}

	class PunctuatorToken : DefaultTokenImpl, IVisitableToken
	{
		public PunctuatorToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitPunctuator(ToString());
		}
	}

	class OperatorToken : DefaultTokenImpl, IVisitableToken
	{
		public OperatorToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitOperator(ToString());
		}
	}

	class StringLiteralToken : DefaultTokenImpl, IVisitableToken
	{
		public StringLiteralToken(string name)
			: base(name)
		{
		}

		void IVisitable.Accept(ITokenVisitor visitor)
		{
			visitor.VisitStringLiteral(ToString());
		}
	}
}
