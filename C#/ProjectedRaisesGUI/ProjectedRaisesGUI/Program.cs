using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    static class Program
    {
        // Purpose:  Accept user input to calculate salary incraease of 4%
        // Author:    David Burchett
        // Date:       2/13/2023
        // Filename: POrojectedRaisesGUI
        // Input:       Starting Salary(double)
        // Output:     New Salary(double)

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //the form that accepts input and sends output
        }
    }
}
