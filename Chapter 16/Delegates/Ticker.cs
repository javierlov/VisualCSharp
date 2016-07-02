
namespace Delegates
{
	using System.Collections;
	using System.Timers;

	public delegate void Tick(int hh, int mm, int ss);

	class Ticker
	{
        public event Tick tick;

		public Ticker()
		{
			ticking.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
			ticking.Interval = 1000; // 1 second
			ticking.Enabled = true;
		}

        //public void Attach(Tick newSubscriber)
        //{
        //    subscribers.Add(newSubscriber);
        //}
		
        //public void Detach(Tick exSubscriber)
        //{
        //    subscribers.Remove(exSubscriber);
        //}

		private void Notify(int hours, int minutes, int seconds)
		{
            //foreach (Tick method in subscribers)
            //{
            //    method(hours, minutes, seconds);
            //}
            if (tick != null)
            {
                tick(hours, minutes, seconds);
            }
		}
	
		private void OnTimedEvent(object source, ElapsedEventArgs args)
		{
			int hh = args.SignalTime.Hour;
			int mm = args.SignalTime.Minute;
			int ss = args.SignalTime.Second;
			Notify(hh, mm, ss);
		}

		private ArrayList subscribers = new ArrayList();
		private System.Timers.Timer ticking = new System.Timers.Timer();
	}
}
