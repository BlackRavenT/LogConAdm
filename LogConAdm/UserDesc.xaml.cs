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
using System.Data.SqlClient;

namespace LogConAdm
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class UserDesc : Window
    {
        public static SqlConnection conn;

        public UserDesc()
        {
            InitializeComponent();
        }

        public UserDesc(SqlConnection Con)
        {
            InitializeComponent();

            conn = Con;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {               
            this.Owner.Show();        
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NewUser a = new NewUser(conn);
            a.Owner = this;
            this.Hide();
            a.Show();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
