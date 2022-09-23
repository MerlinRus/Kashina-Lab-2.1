using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, numericUpDown2);
        }

        private void button1_Click(object sender, EventArgs e, NumericUpDown numericUpDown2)
        {
            Convert.ToDouble(numericUpDown1.Value);
            Convert.ToDouble(numericUpDown2.Value);
            if (Math.Sqrt(((double)numericUpDown2.Value / Math.PI)) <= (Math.Sqrt((double)(numericUpDown1.Value / 2))))
            {
                label3.Text = "Круг поместится";
            }
            else
            {
                label3.Text = "Круг не войдёт";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
