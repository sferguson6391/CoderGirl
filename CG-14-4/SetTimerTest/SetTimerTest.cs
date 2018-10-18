using System;
using Xunit;
using CG_14_4;

namespace SetTimerTest
{
    public class SetTimerTest
    {
        [Fact]
        public void SetTimer_Time()
        {
            var timer = new SetTimer();
            Action<object, System.Timers.ElapsedEventArgs> result = timer.Timer_Elapsed(00:00:00:02)

        }
    }
}
