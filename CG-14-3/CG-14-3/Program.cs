﻿using System;
using System.Timers;

namespace CG_14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the amount of time for your timer (DD:HH:MM:SS): ");
                SetTimer timer = new SetTimer(Console.ReadLine());
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
