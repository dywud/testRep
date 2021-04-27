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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ekz_app
{
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connect = "Data Source=vc-stud-mssql1;Initial Catalog=user47_db;User ID=user47_db;Password=user47";
            string command = "Select name from ekz_pribori";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            SqlCommand cmd = new SqlCommand(command, myConnection);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cb_name.Items.Add(rd.GetString(0));
            }
            myConnection.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connect = "Data Source=vc-stud-mssql1;Initial Catalog=user47_db;User ID=user47_db;Password=user47";
            string command = "delete from ekz_pribori where name = '" + cb_name.Text + "'";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            SqlCommand cmd = new SqlCommand(command, myConnection);
            cmd.ExecuteNonQuery();
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
