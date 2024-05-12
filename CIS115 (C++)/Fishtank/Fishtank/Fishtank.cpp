//Chapter 4 Fish Tank Gallons - starting code
//This program calculates the number of gallons a rectangular fish tank will hold.  
//Created by: David Burchett
//Date: 9/23/22
//
#include <iostream>          
using namespace  std;

int main()           //begining of the main function for this program
{                    //opening code block bracket

//delcare all variables and constants needed 
	double length = 0.0;
	double width = 0.0;
	double height = 0.0;
	double gallons = 0.0;

//prompt the user for the input items and receive them
	cout << "Enter the length:  ";
	cin >> length;
	cout << "Enter the width:  ";
	cin >> width;
	cout << "Enter the height:  ";
	cin >> height;

//calculate the gallons held
	gallons = (length * width * height) / 231;

//Display the gallons to the user

	cout << "The number of gallons is: " << gallons << endl;


	return 0; // This statement indicates that the program has ended successfully.
}//end of the main function