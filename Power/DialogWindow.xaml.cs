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

        public CountdownTimer DWTimer = new CountdownTimer();
         
        public DialogWindow()
        {
            InitializeComponent();

            DialogWindowContext context = new DialogWindowContext();

            context.Capsules.AddRange(DefaultCapsules);

            this.DataContext = context;
        }

        private void SetNow_Selected(object sender, RoutedEventArgs e)
        {
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
            this.Close();
        }
        
        private void Options_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* EXPLANATION
             * 
             Well, when you are unsure of what type an object is in C# you can you the `is` modifier.
             Here, the sender is just an object.
             It could be anything. I used the `is` modifier to make sure that it is a ComboBox.
             I also made a declaration of the combobox if it really is one.
             That way we don't have to say var comboBox = (ComboBox)sender;
             We simply convert the object sender to a combobox since it is one....
             You've read about casting objects right?  => (ComboBox)sender  
             Yeah, I know about casting 
             Awesome. I don't really like casting so much, so I do that...
             Well, moving on.
             Attach back this event in your xaml.
             So that we can give it a run.
             One more time...
            */

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
