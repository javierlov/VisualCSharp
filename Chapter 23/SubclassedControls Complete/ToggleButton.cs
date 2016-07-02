using System;
using System.Windows.Forms;
using System.Drawing;

namespace SubclassedControls
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class ToggleButton : CheckBox
	{
		private string checkedText;
		private string uncheckedText;
		private Color checkedColor;
		private Color uncheckedColor;

		public ToggleButton()
		{
			//
			// TODO: Add constructor logic here
			//
			this.Appearance = Appearance.Button;
			this.checkedText = "Checked";
			this.uncheckedText = "Unchecked";
			this.checkedColor = Color.Gray;
			this.uncheckedColor = this.BackColor;
		}

		public string CheckedText
		{
			get
			{
				return this.checkedText;
			}

			set
			{
				this.checkedText = value;
			}
		}

		public string UncheckedText
		{
			get
			{
				return this.uncheckedText;
			}

			set
			{
				this.uncheckedText = value;
			}
		}

		public Color CheckedColor
		{
			get
			{
				return this.checkedColor;
			}

			set
			{
				this.checkedColor = value;
			}
		}

		public Color UncheckedColor
		{
			get
			{
				return this.uncheckedColor;
			}

			set
			{
				this.uncheckedColor = value;
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (this.Checked)
			{
				this.Text = this.checkedText;
				this.BackColor = this.checkedColor;
			}
			else
			{
				this.Text = this.uncheckedText;
				this.BackColor = this.uncheckedColor;
			}
		}
	}
}
