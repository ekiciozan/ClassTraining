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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HandComputer hcmp = new HandComputer();
            hcmp.computerModel = "MSI";
            hcmp.price = 4000;
            hcmp.processRate = 5.20;
            hcmp.status = '1';
            hcmp.YEAR = -2017;
            hcmp.monitorHeight = 1.57;
            hcmp.monitorWidth = 6.47;

            label1.Text = hcmp.computerModel;
            label2.Text = hcmp.price.ToString();
            label3.Text = hcmp.processRate.ToString();
            label4.Text = hcmp.status.ToString();
            label5.Text = hcmp.YEAR.ToString();
            label6.Text = hcmp.monitorHeight.ToString();
            label7.Text = hcmp.monitorWidth.ToString();
            
        }
    }
}
