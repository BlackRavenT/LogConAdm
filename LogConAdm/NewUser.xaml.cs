using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public static SqlConnection conn;

        public NewUser()
        {
            InitializeComponent();
        }

        public NewUser(SqlConnection Con)
        {
            InitializeComponent();

            conn = Con;
        }

        private void UMan_Checked(object sender, RoutedEventArgs e)
        {
            UFem.IsChecked = false;
        }

        private void UFem_Checked(object sender, RoutedEventArgs e)
        {
            UMan.IsChecked = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            UserDesc a = new UserDesc(conn);
            a.Owner = this.Owner.Owner;
            this.Owner.Close();
            a.Show();
            this.Hide();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            string sqlExpression = "dbo.p_addlogin";
            object result = null;
            string name_user = USurname.Text + ' ' + UName.Text;

            SqlCommand command = new SqlCommand(sqlExpression, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter loginParam = new SqlParameter
            {
                ParameterName = "@loginame",
                Value = NULogin.Text
            };
            command.Parameters.Add(loginParam);
            SqlParameter userParam = new SqlParameter
            {
                ParameterName = "@name",
                Value = name_user
            };

            try
            {
                result = command.ExecuteScalar();
            }
            catch (Exception er)
            {
                Console.WriteLine("Error: " + er.Message);
                Err a = new Err(er.Message);
                a.Show();
            }

            Console.WriteLine("Add user " + NULogin + " with name " + name_user + ". ID = " + result + '\n');

            UserDesc ret = new UserDesc(conn);
            ret.Owner = this.Owner.Owner;
            this.Owner.Close();
            ret.Show();
            this.Hide();
        }
    }
}
