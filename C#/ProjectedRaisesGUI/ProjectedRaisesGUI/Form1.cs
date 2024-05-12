using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //accepts input and increses by 4% then ouputs to label
        {
            double currentSalary = Convert.ToDouble(textBox1.Text);
            double newSalary = currentSalary * 1.04;
            label1.Text = "Your new slaray will be $" + newSalary;
        }
    }
}
