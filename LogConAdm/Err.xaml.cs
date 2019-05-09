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
    /// Логика взаимодействия для Err.xaml
    /// </summary>
    public partial class Err : Window
    {
        public Err()
        {
            InitializeComponent();
        }

        public Err(string str)
        {
            InitializeComponent();
            ErrorMessage.Text = str;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
