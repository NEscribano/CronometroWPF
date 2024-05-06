using System;
using System.Windows;
using System.Windows.Threading;

namespace CronometroWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan cronometroTime;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            cronometroTime = cronometroTime.Add(TimeSpan.FromSeconds(1));
            txtCronometro.Text = cronometroTime.ToString("hh':'mm':'ss");
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            cronometroTime = TimeSpan.Zero;
            txtCronometro.Text = "00:00:00";
        }
    }
}
