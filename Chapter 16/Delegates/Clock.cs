
namespace Delegates
{
	using System.Windows.Forms;
    
	class Clock
	{
		public Clock(TextBox target)
		{
			time = target;
			//Start();
		}

		public void Start()
		{
			// to do
            //pulsed.Attach(new Tick(this.RefreshTime));
            pulsed.tick += new Tick(this.RefreshTime);
		}

		public void Stop()
		{
			// to do
            //pulsed.Detach(new Tick(this.RefreshTime));
            pulsed.tick -= new Tick(this.RefreshTime);
		}

		private void RefreshTime(int hh, int mm, int ss)
		{
			time.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss);
            //time.Text = hh.ToString();
		}

		private Ticker  pulsed = new Ticker();
		private TextBox time;
	}
}
