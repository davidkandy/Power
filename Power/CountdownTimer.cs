using System;
using System.Threading;

namespace Power
{
    public class CountdownTimer
    {
        #region Public Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int CountdownTime { get; private set; }
        #endregion

        #region Constructors
        public CountdownTimer(int hours, int minute, int seconds)
        {
            Hours = hours;
            Minutes = minute;
            Seconds = seconds;
        }

        public CountdownTimer()
        {
        }

        //public CountdownTimer(int timeleft)
        //{
        //    CountdownTime = timeleft;

        //    Hours = CountdownTime / 3600;
        //    Minutes = (CountdownTime - (Hours * 3600)) / 60;
        //    Seconds = CountdownTime - (Hours * 3600) - (Minutes * 60);
        //    There's not much to do here again, I am just need a change. 
        //}


        #endregion

        #region Methods
        /// <summary>
        /// The method to Start counting down
        /// </summary>
        public void Start(Action finalAction = null)
        {
            while (true)
            {

                Thread.Sleep(1000); // It should work as expected now.


                if (Hours > 24 || Minutes > 60 || Seconds > 60)
                    throw new Exception("You entered a Wrong Value that's beyond the bounds of a timer. ");

                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                if (Hours > 0 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }

                if (Hours <= 1 && Minutes == 0 && Seconds == 0)
                {
                    Minutes = 60;
                    Hours = 0;
                }

                if (Minutes <= 60)
                {
                    if (Seconds == 0 && Minutes >= 1)
                    {
                        Minutes -= 1;
                        Seconds = 60;
                    }
                }

                if (Seconds == 0) Seconds = 60;
                Seconds--;

                string hours = DoubleNumber(Hours),
                    minutes = DoubleNumber(Minutes),
                    seconds = DoubleNumber(Seconds);

                Console.WriteLine($"{hours}:{minutes}:{seconds}");

            }

            // This is where the time gets up. So we call the action here.
            // Can you figure out which part of the plan I haven't done yet...
            // What's missing from my code?..
            // The Start(action) ??
            // We'll need to call the start method to start counting down
            // 
            // Alright, I'll give it a try.

            // Explain a little bit further...
            // Lol...You're asking me....
            // Nice one man...
            // Please hold on for a moment.
            // Okay

            // Great, can you do that while I'm away

            // Line 53 mainwindow.cs

            // It worked 
            // But it won't countdown because the DialogWindow Opens, It just showed the message box

            finalAction?.Invoke();
            Console.WriteLine("Time is up            // var DWTimer = new Cou..Sorry Ih tohndle What did you write here??" +
                " something important.");
            //....
            // Man, do you have a cat, or something?...
            // No


            // SO, what's next??

            // Did it work okay? Yes
            // You never created the countdown.

            // !!!");
        }

        /// <summary>
        /// The method to make each property a double digit (e.g 00:00:00)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        string DoubleNumber(int number)
        {
            if (number <= 9) return "0" + number;
            return number.ToString();
        }
        #endregion
    }
}
