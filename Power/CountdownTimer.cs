using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace Power
{
    // 1. First we implement INotifyPropertyChanged
    // Import the necessary namespace and Implement it using your IDE
    // Oh, I just did that. No worries.
    public class CountdownTimer : INotifyPropertyChanged
    {
        #region Properties
        private int _hours = 0;
        private int _minutes = 0;
        private int _seconds = 0;

        //Lol...copy cat...
        // Don't you like typing?...
        // It'll give you good syntax fluency, you know?
        // I get your point tho
        // I will start typing
        // And I'll start deleting my code :)..Lol
        // Lmao... that won't be necessary
        // Lol...cool.
        // You forgot to put the Seconds right.
        // Awesome.
        // Can you give it a run..
        // Yayy.. the TimerView works 
        // But when the time is up, the TimerView window is still up
        // Maybe that should be your assignment??...
        // Find out how to hide it back :shrug:
        // I'm tired for today :)...
        // Alright... Thanks bro, today was a good day.. Till wednesday 
        // Goodnight 
        // Night man..
        // Enjoy

        public int Hours 
        { 
            get => _hours; 
            set
            {
                _hours = value;
                RaisePropertyChanged("Hours");
            }
        }
        public int Minutes
        {
            get => _minutes;
            set
            {
                _minutes = value;
                RaisePropertyChanged("Minutes");
            }
        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                _seconds = value;
                RaisePropertyChanged("Seconds");
            }
        }


        // Now, this is the event that comes with INotifyPropertyChanged.
        // Just like the event we created before, it sends notifications
        // to interested parties when a certain thing happens.

        // In our case, it is going to do that once a property is changed.
        // Okay.. I'm following 

        // Awesome, I went to fish for an implementation that won't give us too much headache
        public event PropertyChangedEventHandler PropertyChanged;


        // Let's create single method where we'll send out those notifications.
        #endregion

        #region Constructors
        public CountdownTimer() { }
        //public CountdownTimer(int hours, int minute, int seconds)
        //{
        //    Hours = hours;
        //    Minutes = minute;
        //    Seconds = seconds;

        //    // So to make things Thread safe you need to wrap it in a Task
        //    // You can read a little about it.
        //    // I read a bit on it.. It said something about putting a private object in a Lock method
        //    // Or something like that, Idon't remember exactly
        //    // One second, lemme check something.
           
        //    // Okay, so we need to wrap it in a task.
        //    // Just watch and see the changes


        //    // Gratefully, we don't need to do anything like that..;
        //    // Funny, cuz that's about it.
        //    // Are you following?
        //    // Yes

        //    // Awesome. 
        //    // Give it a run, lemme think for a bit.
        //    // Ok 

        //    // So I noticed you commented out some of the methods from MainWindow.xaml.cs

        //    // Yes, they are now in the MainView.cs
        //    // Great. I'll head there.

        //}



        public CountdownTimer(int timeleft)
        {
            // Is that it?... 
            // I can't see any other one, except you want me to clear everything inside the constructo
            // What about the errors.
            // Handle them, man. It should be a piece of cake.
            // I'll be back in 5. Take a careful look at it, and try to figure out why you have those errors.

            // No errors on this end bro... 
            // I removed the "CountdownTimer = timeleft" line of code 


            // I've done it already
            // it says 'Invalid expression term '=' 


            // Great. 
            // I was wondering what took you so long...

            Hours = timeleft / 3600;
            Minutes = (timeleft - (Hours * 3600)) / 60;
            Seconds = timeleft - ((Hours * 3600) - (Minutes * 60));
        }


        #endregion

        #region Methods
        
        // Now each time a property changes, we just need to call this method and tell it which property has been updated.
        // Hence, the propertyName field

        // The method invokes the PropertyChanged event we created earlier and the UI gets
        // notified that a certain property has been changed.
        // This way, the UI can then, update based on the changes.
        
        // The next step, and hopefully the final one is making sure that each time
        // a property changes, this method gets called.

        // So we move upwards to the properties available in this class.
        
        void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// The method to Start counting down
        /// </summary>
        public async Task Start(Action finalAction = null)
        {
            while (true)
            {
                // Thread.Sleep(1000); // It should work as expected now.
                await Task.Delay(1000);

                //if (Hours > 24 || Minutes > 60 || Seconds > 60)
                //    throw new Exception("The value entered is beyond the bounds of a timer. ");

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
            Audio();
            await Task.Delay(8000);

            finalAction?.Invoke();
        }
        void Audio()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.beepbeep);
            player.Play();
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
