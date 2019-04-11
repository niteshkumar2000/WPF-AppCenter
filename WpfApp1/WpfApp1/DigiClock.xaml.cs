using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for DigiClock.xaml
    /// </summary>
    public partial class DigiClock : Window
    {
        int counter,input_count;
        DispatcherTimer timer = new DispatcherTimer();
        public DigiClock()
        {
            InitializeComponent();
            counter = 0;
            input_count = 0;
        }
        private void Startclock() {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Tickevent;
            timer.Start();
        }

        private void Tickevent(object sender, EventArgs e)
        {
            counter++;
            if (counter <= input_count)
            {
                digiclock.Text = DateTime.Now.ToString(@"hh\:mm\:ss tt");
            }
            else { 
                SoundPlayer player = new SoundPlayer(@"C:\Users\Niteshkumar\source\repos\WpfApp1\WpfApp1\alarm.wav");
                player.Load();
                player.Play();
            var result = MessageBox.Show("Time Up!!!", "Information", MessageBoxButton.OK, MessageBoxImage.Information).ToString();
            if (result == "OK")
                {
                    player.Stop();
                    timer.Stop();
                }
                digiclock.Text = DateTime.Now.ToString(@"hh\:mm\:ss");
            }
            digidate.Text = DateTime.Now.ToString(@"dd\\MM\\yyyy");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow x = new MainWindow();
            x.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input_count = Convert.ToInt32(txtcount.Text);
            Startclock();
        }
    }
}
