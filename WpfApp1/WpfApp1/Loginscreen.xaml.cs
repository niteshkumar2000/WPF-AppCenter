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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Loginscreen.xaml
    /// </summary>
    public partial class Loginscreen : Window
    {
        public Loginscreen()
        {
            InitializeComponent();
        }

        private void Btnsumbit_Click(object sender, RoutedEventArgs e)
        {
            string row = "";
            //string Name = "Hello Mr." + txtusername.Text;
            //MessageBox.Show(Name,"Information Box",MessageBoxButton.OK);
            string name = txtusername.Text;
            string password = txtpassword.Password.ToString();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";

            string query = "SELECT `Password` FROM user WHERE `Name` = '" + name + "'";

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
                        row = reader.GetString(0);
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

            if (row == password) {
                MessageBox.Show("Login Success!!!","Information",MessageBoxButton.OK);
                this.Hide();
                MainWindow x = new MainWindow();
                x.ShowDialog();
            }
            else {
                MessageBox.Show("Wrong Password!!!", "Information", MessageBoxButton.OK);
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
