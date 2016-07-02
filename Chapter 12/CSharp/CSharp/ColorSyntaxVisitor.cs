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

		// ITokenVisitor methods        

		void ITokenVisitor.VisitComment(string token) 
		{
			// to do
		}

		void ITokenVisitor.VisitIdentifier(string token) 
		{
			// to do
		}
			
		void ITokenVisitor.VisitKeyword(string token) 
		{
			// to do
		}
			
		void ITokenVisitor.VisitOperator(string token) 
		{
			// to do
		}
			
		void ITokenVisitor.VisitPunctuator(string token)
		{
			// to do
		}
			
		void ITokenVisitor.VisitStringLiteral(string token)
		{
			// to do
		}
			
		void ITokenVisitor.VisitWhitespace(string token) 
		{
			// to do
		}

		private readonly RichTextBox target;
		private int index;   
     
    }
}
