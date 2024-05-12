using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  Allows user to enter scores to check if they are accepted or rejected
// Author:   David Burchett
// Date:     2/19/2023
// Filename: Admission.cs
// Input:    GPA & Admission test score
// Output:   Accept or pass

namespace Admission
{
    class Admission
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your GPA: "); //accepting user inputs
            double gradePointAverage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your admission test score: ");
            int admissionTestScore = Convert.ToInt32(Console.ReadLine());

            if(gradePointAverage >= 3 && admissionTestScore >= 60) //first check for pass with high gpa
            {
                Console.WriteLine("Accept");
            } 

            else if(gradePointAverage < 3 && admissionTestScore >= 80) //second check for pass with low gpa
            {
                Console.WriteLine("Accept");
            }

            else //failure condition if none are met
            {
                Console.WriteLine("Reject");
            }

            Console.WriteLine("press enter to close this window");
            string closeConsole = Console.ReadLine();
        }
    }
}
