using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace CG_14_4
{
    class SetTimer
    {
        public DateTime StartTime { get; set; }
        public Timer Timer { get; set; }
        public TimeSpan Span { get; set; }
        public ElapsedEventHandler OnTimedEvent { get; private set; }

        public SetTimer(string time)
        {
            if (string.IsNullOrWhiteSpace(time))
                throw new Exception("Input is required.");
            Span = TimeSpan.Parse(time);
            Timer = new Timer(Span.TotalMilliseconds);
            Timer.Elapsed += Timer_Elapsed;
            Timer.AutoReset = false;
            Timer.Enabled = true;
            StartTime = DateTime.Now;
        }

        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Ding! {e.SignalTime}");
        }
    }
}
