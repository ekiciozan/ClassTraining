using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTraining
{
    public class Computer
    {
        public string computerModel;
        public int price;
        public char status;
        public double processRate;
        private int year;
        /* Encapsulation - Kalıtım */
        public int YEAR
            {
            get { return year; }
            set { year = Math.Abs(value); }
            }
    }
}
