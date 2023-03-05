using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Computer cmp = new Computer();
            cmp.computerModel = "Asus";
            cmp.price = 2000;
            cmp.status = '1';
            cmp.processRate = 4.16;

           label1.Text = cmp.computerModel;
           label2.Text = cmp.price.ToString();
           label3.Text = cmp.processRate.ToString();
           label4.Text = cmp.status.ToString();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
