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

		// to do: implement all the Visit methods        

		private readonly RichTextBox target;
		private int index;        
    }
}
