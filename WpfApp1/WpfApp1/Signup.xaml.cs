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
using MySql.Data.MySqlClient;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Window
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Btnsumbit_Click_1(object sender, RoutedEventArgs e)
        {
            string name = txtusername.Text;
            string pass = txtpassword.Password.ToString();
            string c_pass = txtconfirmpassword.Password.ToString();
            
            if (c_pass == pass)
            {
                
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";

                string query = "INSERT INTO user(`Name`, `Password`) VALUES ('" + name + "', '" + pass + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string row = reader.GetString(0) + '\n' + reader.GetString(1);
                            MessageBox.Show(row);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }


                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Good to Go", "Information", MessageBoxButton.OK);
                this.Hide();
                MainWindow x = new MainWindow();
                x.ShowDialog();
            }
            else {
                MessageBox.Show("Password Mismatch", "Information", MessageBoxButton.OK);
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow x = new MainWindow();
            x.ShowDialog();
        }
    }
}
