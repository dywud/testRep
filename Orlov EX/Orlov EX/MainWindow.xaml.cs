using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Orlov_EX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable raspisanieTable;

        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           /* string sql = "SELECT * FROM Raspisanie";
            raspisanieTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                adapter.InsertCommand = new SqlCommand("sp_InsertKorzina2", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("den_nedeli", SqlDbType.NVarChar, 0, "den_nedeli"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("nomer_pari", SqlDbType.NVarChar, 0, "nomer_pari"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("nazvanie", SqlDbType.NVarChar, 0, "nazvanie"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("auditoriya", SqlDbType.Date, 0, "auditoriya"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "id");
                parameter.Direction = ParameterDirection.Output;
                connection.Open();
                adapter.Fill(raspisanieTable);
                raspisanieGrid.ItemsSource = raspisanieTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            */
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Dobavlenie a = new Dobavlenie();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }
    }
}
