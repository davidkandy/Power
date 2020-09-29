using System.Windows.Controls;
using System.Windows;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Power

{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public MainView()
        {
            InitializeComponent();
        }

        protected async void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                // Let's go to MainWindow.xaml.cs

                TimerCompleted?.Invoke(this, dialog.DWTimer);
                Action action = new Action(ShutdownComputer);

                // Now once the dialog returns successfully.
                // We are going to pass it DWTimer object to this control's DataContext.
                // This will make it possible to bind to the properties of be DataContext as required.
                // Can you set the DataContext to the DWTimer Object?...

                // No.. I have forgotten most of what I read in Data Binding
                // 
                // That's too bad, It's quite straight forward actually.
                // Now, I won't forget again 

                this.DataContext = dialog.DWTimer;
                // And that does that.
                // Replicate it around the other methods.
                // Done.
                // Awesome.
                // Wait a second...
                // Binding it in MainView doesn't seem really useful...
                // MainView only contains buttons...
                // I have a small idea.

                // We create an event here, and then invoke it once we
                // Okay.. I am following your lead
                await dialog.DWTimer.Start(action);
            }

            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Shutdown"));
            //dialog.DWTimer.Start(action);
        }
        protected async void Hibernate_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                TimerCompleted?.Invoke(this, dialog.DWTimer);
                Action action = new Action(HibernateComputer);
                this.DataContext = dialog.DWTimer;
                await dialog.DWTimer.Start(action);
            }
        }

        protected async void Restart_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                TimerCompleted?.Invoke(this, dialog.DWTimer);
                Action action = new Action(RestartComputer);
                this.DataContext = dialog.DWTimer;
                await dialog.DWTimer.Start(action);
            }

            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Restart"));
            //dialog.DWTimer.Start(action);
        }
        protected async void Sleep_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog = new DialogWindow();
            bool? result = dialog.ShowDialog();

            if (dialog.DialogResult == true)
            {
                TimerCompleted?.Invoke(this, dialog.DWTimer);
                Action action = new Action(SleepComputer);
                this.DataContext = dialog.DWTimer;
                await dialog.DWTimer.Start(action);
            }

            //Action action = new Action(() => MessageBox.Show("Timer just went off", "Sleep"));
            //dialog.DWTimer.Start(action);
        }

        public event EventHandler<CountdownTimer> TimerCompleted;

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

    }
}
