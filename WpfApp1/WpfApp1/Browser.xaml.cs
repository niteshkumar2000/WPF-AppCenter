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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        public Browser()
        {
            InitializeComponent();
            myBrowser.Navigate(new Uri("http://www.google.com"));
        }

        private void btnInternal_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            myBrowser.Navigate(new Uri("http://github.com/niteshkumar2000"));
        }
    }
}
