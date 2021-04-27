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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ekz_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString;
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(name_tb.Text == "" || data_postypleniya_tb.Text == "" || data_remonta_tb.Text == "" || price_tb.Text == "" || description_tb.Text == "" || worker_tb.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            } else
            {
                string connect = "Data Source=vc-stud-mssql1;Initial Catalog=user47_db;User ID=user47_db;Password=user47";
                SqlConnection myConnection = new SqlConnection(@connect);
                string command = "delete from ekz_pribori where name = '" + cb_name.Text + "'";
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(command, myConnection);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                myConnection.Open();
                string command2 = "Insert into ekz_pribori(name, data_postypleniya, data_remonta,price, description, id_worker) values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                string name = name_tb.Text;
                string data_postypleniya = data_postypleniya_tb.Text;
                string data_remonta = data_remonta_tb.Text;
                int price = Convert.ToInt32(price_tb.Text);
                string description = description_tb.Text;
                int id_worker = Convert.ToInt32(worker_tb.Text);
                string newCommand = string.Format(command2, name, data_postypleniya, data_remonta, price, description, id_worker);
                SqlCommand myCommand2 = new SqlCommand(newCommand, myConnection);
                myCommand2.ExecuteNonQuery();
                myConnection.Close();
            }
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
    }
}