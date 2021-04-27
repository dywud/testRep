using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Orlov_EX
{
    /// <summary>
    /// Interaction logic for Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Window
    {
        public Dobavlenie()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string connect = "Data Source=vc-stud-mssql1;Initial Catalog=user56_db;User ID=user56_db;Password=user56";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            string den_nedeli = dn.Text;
            string nomer_pari = np.Text;
            string nazvanie = naz.Text;
            string auditoriya = aud.Text;

            if (dn.Text == "" || np.Text == "" || naz.Text == "" || aud.Text == "")
            {
                MessageBox.Show(string.Format("Заполните поля"), "Сообщение");
            }
            else {

                ClassLibrary1.Class1 a = new ClassLibrary1.Class1();
                string y = np.Text;
                bool qwe = a.num(y);

                y = naz.Text;
                bool qwe1 = a.let(y);

                y = aud.Text;
                bool qwe2 = a.num(y);

                y = dn.Text;
                bool qwe3 = a.let(y);


                if (qwe == false)
                {
                    MessageBox.Show(string.Format("Некорректно заполнено поле 'Номер пары'"), "Сообщение");
                }

                else if (qwe1 == false)
                {
                    MessageBox.Show(string.Format("Некорректно заполнено поле 'Название'"), "Сообщение");
                }

                else if (qwe2 == false)
                {
                    MessageBox.Show(string.Format("Некорректно заполнено поле 'Аудитория'"), "Сообщение");
                }

                else if (qwe3 == false)
                {
                    MessageBox.Show(string.Format("Некорректно заполнено поле 'День недели'"), "Сообщение");
                }

                else
                {

                    string sInsSql = "Insert into Raspisanie(den_nedeli, nomer_pari, nazvanie, auditoriya) Values('{0}', '{1}', '{2}', '{3}')";

                    string sInsSotr = string.Format(sInsSql, den_nedeli, nomer_pari, nazvanie, auditoriya);
                    SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
                    cmdIns.ExecuteNonQuery();
                    MessageBox.Show(string.Format("Данные успешно добавлены"), "Сообщение");
                    MainWindow c = new MainWindow();
                    this.Hide();
                    c.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
