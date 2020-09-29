using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace Power
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // I remember I named the UserControls in your xaml
            // Can you fetch me their names?...

            // MainEl & TimerEl

            // Now, we get that subscribe to that event fro MainView.
            // You can read about events later :)

            MainEl.TimerCompleted += (s, e) =>
            {
                TimerEl.DataContext = e;

                TimerEl.Visibility = Visibility.Visible;
                MainEl.Visibility = Visibility.Hidden;
            };


        }

        private void StartupRun_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ScheduleStartupCommand_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Select what you want your system to do when next your system boots", "Select a command", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                return;
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks to everyone who contributed their ideas and support to help create this, I can't be grateful enough! Time is Power!" +
                "                             Tell me what you think! davidkandy98@gmail.com +2348088482027", "About", MessageBoxButton.OK);
        }
        /*
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);


        protected void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                Action action = new Action(ShutdownComputer);
                dialog.DWTimer.Start(action);
            }
            
            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Shutdown"));
            //dialog.DWTimer.Start(action);

        }
        protected void Hibernate_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                Action action = new Action(HibernateComputer);
                dialog.DWTimer.Start(action);
            }
            

        }

        protected void Restart_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                Action action = new Action(RestartComputer);
                dialog.DWTimer.Start(action);
            }
            
            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Restart"));
            //dialog.DWTimer.Start(action);
        }
        protected void Sleep_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                Action action = new Action(SleepComputer);
                dialog.DWTimer.Start(action);
            }

            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Sleep"));
            //dialog.DWTimer.Start(action);

        }
        private void StartupRun_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ScheduleStartupCommand_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Select what you want your system to do when next your system boots", "Select a command", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                return;
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks to everyone who contributed their ideas and support to help create this, I can't be grateful enough! Time is Power!" +
                "                             Tell me what you think! davidkandy98@gmail.com +2348088482027", "About", MessageBoxButton.OK);
        }


        #region Private methods

        static void RestartComputer()
        {
            Process.Start("shutdown", "/r /t 0");
        }

        static void SleepComputer()
        {
            Console.WriteLine(MessageBox.Show("Timer just went off", "Sleep"));
        }
        static void HibernateComputer()
        {
            SetSuspendState(true, true, true);
        }
        static void ShutdownComputer()
        {
            Process.Start("shutdown", "/s /f /t 0");
        }

        #endregion
        */
    }
}
