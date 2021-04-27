using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace манго
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formload = new Form1();
            formload.Show();
        }

        private void Регистрация_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 formload = new Form4();
            formload.Show();
        }
    }
}
