
namespace Operators
{
	class Clock
	{
		public Clock()
		{
			System.DateTime now = System.DateTime.Now;
			hour = new Hour(now.Hour);
			minute = new Minute(now.Minute);
			second = new Second(now.Second);
			pulsed.tick += new Tick(tock);
		}

		public Clock(Hour hh, Minute mm, Second ss)
		{
			hour = hh;
			minute = mm;
			second = ss;
			pulsed.tick += new Tick(tock);
		}

		public int Hour
		{
			get { return hour.Value; }
		}

		public int Minute
		{
			get { return minute.Value; }
		}

		public int Second
		{
		   get { return second.Value; }
		}

		private void tock()
		{
			second++;
			if (second == 0)
			{
				minute++;
				if (minute == 0)
				{
					hour++;
				}
			}
		}

		private Ticker  pulsed = new Ticker();
		private Hour hour;
		private Minute minute;
		private Second second;
	}
}
