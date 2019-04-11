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
using Microsoft.Win32;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Audio.xaml
    /// </summary>
    public partial class Audio : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;
        public Audio()
        {
            InitializeComponent();
            filename = "\0";
        }

        private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.FileName;
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                Filename.Content = filename;
                mediaPlayer.Play();
            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mediaPlayer.Stop();
            this.Hide();
            MainWindow x = new MainWindow();
            x.ShowDialog();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                if (!mediaPlayer.NaturalDuration.HasTimeSpan)
                {
                    lblStatus.Content = mediaPlayer.Position.ToString(@"mm\:ss");
                }
                else
                {
                    lblStatus.Content = mediaPlayer.Position.ToString(@"mm\:ss") + @"\" + mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                }
            }
            else
            {
                lblStatus.Content = "No file selected...";
            }
            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
    }
}