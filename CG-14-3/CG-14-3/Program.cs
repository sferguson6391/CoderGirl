using System;
using System.Timers;

namespace CG_14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of time for your timer (seconds, minutes, or hours): ");
            string input = Console.ReadLine();

            Timer userTimer = new Timer(2000);

            userTimer.Elapsed += UserTimer_Elapsed;

            userTimer.Start();
            Console.ReadLine();
        }

        private static void UserTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss.fff}");
        }
    }
}
