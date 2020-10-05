using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Power
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        static List<TimeCapsule> DefaultCapsules = new List<TimeCapsule>
        {
            new TimeCapsule
            {
                Name = "Now",
                TotalSeconds = 1
            },
            new TimeCapsule
            {
                Name = "30 Seconds",
                TotalSeconds = 30
            },
            new TimeCapsule
            {
                Name = "One Minute",
                TotalSeconds = 60
            },
            new TimeCapsule
            {
                Name = "Two Minutes",
                TotalSeconds = 120
            },
            new TimeCapsule
            {
                Name = "Five Minutes",
                TotalSeconds = 300
            },
            new TimeCapsule
            {
                Name = "Ten Minutes", 
                TotalSeconds = 600
            },
            new TimeCapsule
            {
                Name = "Thirty Minutes",
                TotalSeconds = 1800
            },
            new TimeCapsule
            {
                Name = "One Hour",
                TotalSeconds = 3600
            }
        };


        // Lol...Hold on one second after that one..
        // You used ; instead of ,
        // Notice all the places I used a , Yeah 
        // I corrected myself
        // Awesome.
        // Lemme just plug it in to the datacontext, then you can fire away.
        // Done. Carry on.
        // Fill in the rest...
        // I wish I knew what was next
        // Maybe if you told me 
        // Lol...It's just more time at the top there. Just like the old app.
        // I think it's Okay ...For now.
        // Awesome.
        // Now let's see what happens on SelectionChanged.
        // Run the app in Debug mode.
        // Give it a run and change the items of the combobox
        // Aiit


        public CountdownTimer DWTimer = new CountdownTimer();
         
        public DialogWindow()
        {
            InitializeComponent();

            DialogWindowContext context = new DialogWindowContext();

            context.Capsules.AddRange(DefaultCapsules);

            this.DataContext = context;

            // Now we move to DialogWindow.xaml
        }

        private void SetNow_Selected(object sender, RoutedEventArgs e)
        {
            // Remember you created a class that would store the values of each time selected here.
            // We made the changes when each combobox was 'Selected' or something like that.
            // Can you try to create the event from your xaml?...
        }

        private void CancelTimer_Click(object sender, RoutedEventArgs e)
        {
            hh.IsEnabled = mm.IsEnabled = ss.IsEnabled = false;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //hh.IsEnabled = mm.IsEnabled = ss.IsEnabled = CancelTimer.IsEnabled = false;

            this.Close();
        }
        
        private void Options_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Don't worry, I remember I detached this event.
            // Yeah 

            // Well, when you are unsure of what type an object is in C# you can you the `is` modifier.
            // Here, the sender is just an object.
            // It could be anything. I used the `is` modifier to make sure that it is a ComboBox.
            // I also made a declaration of the combobox if it really is one.
            // That way we don't have to say var comboBox = (ComboBox)sender;
            // We simply convert the object sender to a combobox since it is one....
            // You've read about casting objects right?  => (ComboBox)sender  
            // Yeah, I know about casting 
            // Awesome. I don't really like casting so much, so I do that...
            // Well, moving on.
            // Attach back this event in your xaml.
            // So that we can give it a run.
            // One more time...

            // The whole point of the Debug session was to find the type of the item that was selected.
            // Can you try it yourself? Debug again, and look at the contents of e with your debugger.
            // Tell me what Item was selected.... OKAY
            // Sender is System.Windows.Controls.ComboBox and e is System.Windows.Controls.SelectionChangedEventArgs
            // Great, what about the contents of e, there's and arrow you can click to expand e and see it's properties.
            // I don't know what I'm exactly looking for
            // Hold on, lemme see if I can make a small vid
            // Alright 
            // Try again...
            // Hold on for a moment...
            // Sure.
            // cool, I'm compressing a vid at the moment, I'll send it to you in a bit.
            // I wanted you to explore the e object so that you can be able to tell what it contains and how you
            // can find the selected object. 
            // is it  System.Windows.Controls.ComboBox items.Count 8 ???
            // actually it's e.AddedItems[0] 
            // But then the thing is studying it in debug mode is how you actually get your answer. It could be anything.
            // [0] this means the first option right?Yup.

            // I sent you the video anyways. 
            // So let's retrieve the selected item...
            // What does the error say?...
            // I've fixed it 
            // Nice. So you get everything we just did?... 
            // Yes
            // Awesome. Give it a run, man.. It works perfectly 
            // Do you think you'll be available tomorrow?...
            // Yes
            // Well, let's do more, then..
            // Okay bro
            // Working as expected :)?
            //  YUPPP
            // 
            // Lol, cool. Enjoy, man 
            // No assignments today, Just cleanup, play around and push to github.
            // Alright man... take care of yourself.
            
            // I will. You too, bro.
            var selected = e.AddedItems[0];

            if (sender is ComboBox comboBox && selected is TimeCapsule capsule)
            {
                /*
                string value = item.Content.ToString();

                switch (value)
                {
                    case "Now":
                        DWTimer.Seconds = 1;
                        break;

                    case "30 Seconds":
                        DWTimer.Seconds = 30;
                        break;
                     
                    case "45 Seconds":
                        DWTimer.Seconds = 45;
                        break;

                    case "1 Minute":
                        DWTimer.Seconds = 1;
                        break;

                    default:
                        MessageBox.Show("Time selected not in bound");
                        break;
                }
                */

                // Easy, huh?
                DWTimer = new CountdownTimer((int)capsule.TotalSeconds);
            }

        }
    }
}
