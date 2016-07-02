namespace CSharp
{
    using System;
	using System.Windows.Forms;
	using System.Drawing;

    sealed class ColorSyntaxVisitor : ITokenVisitor
    {
        public ColorSyntaxVisitor(RichTextBox rtb)
        {
            target = rtb;
            target.Clear();
            index = 0;
		}

		private void Write(string token, Color color)
		{
			target.AppendText(token);
			target.Select(index, index + token.Length);
			index += token.Length;
			target.SelectionColor = color;
		}

		// ITokenVisitor methods        

		void ITokenVisitor.VisitComment(string token) 
		{
			Write(token, Color.Black);
		}

		void ITokenVisitor.VisitIdentifier(string token) 
		{
			Write(token, Color.Black);
		}
			
		void ITokenVisitor.VisitKeyword(string token) 
		{
			Write(token, Color.Blue);
		}
			
		void ITokenVisitor.VisitOperator(string token) 
		{
			Write(token, Color.Black);
		}
			
		void ITokenVisitor.VisitPunctuator(string token)
		{
			Write(token, Color.Black);
		}
			
		void ITokenVisitor.VisitStringLiteral(string token)
		{
			Write(token, Color.Green);
		}
			
		void ITokenVisitor.VisitWhitespace(string token) 
		{
			Write(token, Color.Black);
		}

		private readonly RichTextBox target;
		private int index;   
     
    }
}
