﻿using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTimer.Displayer d = new MyTimer.Displayer(MyTimer.InitTimer);

            Console.WriteLine("Get interval in seconds:");
            int sec = int.Parse(Console.ReadLine());

            d(sec);

            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            

            Console.WriteLine("Shutingdown the application...");

            //MyTimer.StopTimer();

        }
    }
}