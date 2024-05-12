using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    static class Program
    {
        // Purpose:  Calculate cost of moving
        // Author:    David Burchett
        // Date:       2/13/2023
        // Filename: MoveEstimatorGUI
        // Input:       hours(int) miles(int)
        // Output:     final cost(int)

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //calls the form that accepts user input and display output
        }
    }
}
