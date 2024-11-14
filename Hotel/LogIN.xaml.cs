using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel
{
    /// <summary>
    /// Interaction logic for LogIN.xaml
    /// </summary>
    public partial class LogIN : Page
    {
        public LogIN()
        {
            InitializeComponent();
        }
        

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            if (emailtext.Text == "admin@gmail.com" && passtext.Text == "admin123456")
            {
                MessageBox.Show("Admin Login Successfull!");
                NavigationService.Navigate(new Admin());
            }
            else if (emailtext.Text == null || passtext.Text == null)
            {
                MessageBox.Show("Login Unsuccessfull");
            }
            else
            {
                MessageBox.Show("Login Successfull");
            }
            
            

        }

        private void SIGNUP_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUp());
        }
    }
}
