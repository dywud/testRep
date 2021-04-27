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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            Form3 formload = new Form3();
            formload.Show();
        }
    }
}
