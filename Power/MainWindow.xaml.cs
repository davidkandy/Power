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

            MainEl.TimerStarted += (s, e) =>
            {
                TimerEl.DataContext = e;

                TimerEl.Visibility = Visibility.Visible;
                MainEl.Visibility = Visibility.Hidden;
            };

            MainEl.TimerCompleted += (s, e) =>
            {
                TimerEl.DataContext = e;

                TimerEl.Visibility = Visibility.Hidden;
                MainEl.Visibility = Visibility.Visible;
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
    }
}
