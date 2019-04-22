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

namespace LogConAdm
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class UserDesc : Window
    {
        public UserDesc()
        {
            InitializeComponent();
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
            NewUser a = new NewUser();
            a.Owner = this;
            this.Hide();
            a.Show();
        }
    }
}
