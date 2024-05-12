using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //takes the 2 user inputs and then outputs total cost
        {
            int hours = Convert.ToInt32(hoursTextBox.Text);
            int miles = Convert.ToInt32(milesTextBox.Text);
            int totalCost = 200 + (hours * 150) + (miles * 2);
            label1.Text = "The total cost for the move is $" + totalCost;
        }
    }
}
