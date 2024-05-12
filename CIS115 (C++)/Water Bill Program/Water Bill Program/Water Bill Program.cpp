//Created by David Kyle Burchett on 10/9/22
//This program provides the cost of a new bill provided the previous and current gallons used
#include <iostream>
#include <iomanip>
using namespace std;


int main()
{
	//declare and initilize variables
	int current = 0;
	int previous = 0;
	int gallons = 0;
	double newBill = 0.0;

	//Prompt user for inputs
	cout << "Enter the current meter reading : ";
	cin >> current;

	cout << "Enter the previous meter reading : ";
	cin >> previous;

	//calculate gallons and bill
	gallons = current - previous;
	newBill = gallons / 1000.00 * 10.00;

	//set bill if less than $39.99
	if (newBill < 39.99) {
		newBill = 39.99;
	}
	
	//output
	cout << fixed << setprecision(2);
	cout << "The number of gallons used is : " << gallons << endl;
	cout << "This month�s bill is : " << newBill << endl;

	return 0;
}
//end of program