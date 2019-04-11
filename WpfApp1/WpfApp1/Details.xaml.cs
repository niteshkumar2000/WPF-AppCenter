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
using System.Windows.Forms;
using System.Drawing;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using MessageBox = System.Windows.Forms.MessageBox;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        private SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();
        public Details()
        {
            InitializeComponent();
            speechRecognizer.SpeechRecognized += speechRecognizer_SpeechRecognized;


            GrammarBuilder grammarBuilder = new GrammarBuilder();
            Choices commandChoices = new Choices("weight", "color", "size");
            grammarBuilder.Append(commandChoices);

            Choices valueChoices = new Choices();
            valueChoices.Add("normal", "bold");
            valueChoices.Add("red", "green", "blue");
            valueChoices.Add("small", "medium", "large");
            grammarBuilder.Append(valueChoices);

            speechRecognizer.LoadGrammar(new Grammar(grammarBuilder));
            speechRecognizer.SetInputToDefaultAudioDevice();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            speechRecognizer.Dispose();
            this.Hide();
            MainWindow x = new MainWindow();
            x.ShowDialog();
        }
        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.FontWeight = FontWeights.Bold;
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox1.FontWeight = FontWeights.Normal;
        }

        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            textBox1.FontStyle = FontStyles.Italic;
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox1.FontStyle = FontStyles.Normal;
        }

        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.FontSize < 18)
            {
                textBox1.FontSize += 2;
            }
        }

        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.FontSize > 10)
            {
                textBox1.FontSize -= 2;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox1.SelectionBrush = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Speak(textBox1.Text);
            }
            else {
                MessageBox.Show("Write Something", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnToggleListening_Click(object sender, RoutedEventArgs e)
        {
            if(btnToggleListening.IsEnabled == true)
				speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
			else
				speechRecognizer.RecognizeAsyncStop();
        }

        private void speechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //lblDemo.Content = e.Result.Text;
            if (e.Result.Words.Count == 2)
            {
                string command = e.Result.Words[0].Text.ToLower();
                string value = e.Result.Words[1].Text.ToLower();
                switch (command)
                {
                    case "weight":
                        FontWeightConverter weightConverter = new FontWeightConverter();
                        lblDemo.FontWeight = (FontWeight)weightConverter.ConvertFromString(value);
                        break;
                    case "color":
                        lblDemo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(value));
                        break;
                    case "size":
                        switch (value)
                        {
                            case "small":
                                lblDemo.FontSize = 12;
                                break;
                            case "medium":
                                lblDemo.FontSize = 24;
                                break;
                            case "large":
                                lblDemo.FontSize = 48;
                                break;
                        }
                        break;
                }
            }
        }
    }
    
}
