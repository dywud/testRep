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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Регистрация_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formload = new Form2();
            formload.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 formload = new Form3();
            formload.Show();
        }
    }
}
