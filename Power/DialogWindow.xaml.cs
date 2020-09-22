using System;
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

        public CountdownTimer DWTimer = new CountdownTimer();

        public DialogWindow()
        {
            InitializeComponent();
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
            if (sender is ComboBox comboBox && comboBox.SelectedItem is ComboBoxItem item) //<-- Kindly explain this line again
            {
                string value = item.Content.ToString();

                switch (value)
                {
                    case "Now":
                        DWTimer.Seconds = 2;
                        break;

                    case "30 Seconds":
                        DWTimer.Seconds = 30;
                        break;
                     
                    case "45 Seconds":
                        DWTimer.Seconds = 45;
                        break;

                    case "1 Minute":
                        DWTimer.Seconds = 60;
                        break;

                    default:
                        MessageBox.Show("Time selected not in bound");
                        break;
                }
            }

            // Nice work so far...
            // Interesting you actually did not create a new class in the last code
            // you wrote?
            // Isn't this 'DWTimer' the same class that counts down?... Yes
            // Well, that still works. We can use that.
            // You need to be like new CountdownTimer(), somewhere though.
            // Can you do that?...
            // Done...
            // Great. Now once we press okay, this dialog is meant to close, 
            // but you need to set DialogResult to True so that we know that 
            // the timer has bee Carry on...            //n started.
            // Now we need to go back to you MainWindow.xaml.cs
            // Okay

        }
    }
}
