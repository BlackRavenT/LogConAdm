using System;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogConAdm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            string username = ULogin.Text;
            string userpass = UPassword.Password;
            int userpassh = UPassword.Password.GetHashCode();

            Console.WriteLine("Input " + username + " with " + userpass + " (" + userpassh + ')');
            string str = "";
            int flag = ConnectSQLServer.Connection.ConnToDB(username, userpass, out str);

            if (flag == 0)
            {
                AdmMenu a = new AdmMenu(username);
                a.Owner = this;
                a.Show();
                this.Hide();
            }
            else if (flag == 1)
            {
                Console.WriteLine("Error from MW: " + str);
                Err a = new Err(str);
                a.Show();
            }
        }

    }
}
