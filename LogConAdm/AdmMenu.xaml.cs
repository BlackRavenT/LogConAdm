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
    /// Логика взаимодействия для Adm.xaml
    /// </summary>
    public partial class AdmMenu : Window
    {
        public static SqlConnection Con;

        public AdmMenu()
        {
            InitializeComponent();
            this.Owner.Close();
        }

        public AdmMenu(string str, SqlConnection conn)
        {
            InitializeComponent();
            HelloMessage.Text += ", " + str + '!';
            Con = conn;
        }   

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Users_Click(object sender, RoutedEventArgs e)
        {
            UserDesc a = new UserDesc(Con);
            a.Owner = this;
            this.Hide();
            a.Show();
        }
    }

}
