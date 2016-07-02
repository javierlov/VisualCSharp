
namespace Operators
{
	using System.Timers;

	public delegate void Tick();

	class Ticker
	{
		public Ticker()
		{
			ticking.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
			ticking.Interval = 1000; // 1 second
			ticking.Enabled = true;
		}
	
		public event Tick tick;

		private void OnTimedEvent(object source, ElapsedEventArgs args)
		{
			if (tick != null)
			{
				tick();
			}
		}

		private System.Timers.Timer ticking = new System.Timers.Timer();
	}
}
