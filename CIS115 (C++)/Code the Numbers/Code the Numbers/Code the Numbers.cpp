//Created by David Burchett on 10/16/22
//Code the Numbers - sort numbers based on value from three inputs

#include <iostream>
#include <iomanip> //for formatting numbers to the screen
using namespace std;

int main()
{
	//declare variables
	int num1 = 0;
	int num2 = 0;
	int num3 = 0;
	int smallNum = 0;
	int midNum = 0;
	int largeNum = 0;


	//starting message
	cout << "**** Number Ordering Program **** \n";

	//ask the user for the three inputs
	cout << "Enter the first whole number: ";
	cin >> num1;
	cout << "Enter the second whole number: ";
	cin >> num2;
	cout << "Enter the thrid whole number: ";
	cin >> num3;


	//Calculate the size of the numbers

	if ((num1 <= num2) && (num1 <= num3)) //smallNum
		smallNum = num1;
	else if ((num2 <= num1) && (num2 <= num3))
		smallNum = num2;
	else
		smallNum = num3;

	if (((num1 <= num2) && (num1 >= num3)) || ((num1 >= num2) && (num1 <= num3))) //midNum
		midNum = num1;
	else if (((num2 <= num1) && (num2 >= num3)) || ((num2 >= num1) && (num2 <= num3)))
		midNum = num2;
	else
		midNum = num3;

	if ((num1 >= num2) && (num1 >= num3)) //largeNum
		largeNum = num1;
	else if ((num2 >= num1) && (num2 >= num3))
		largeNum = num2;
	else
		largeNum = num3;


	//display the numbers
	cout << "The smallest number is: " << smallNum << endl;
	cout << "The middle number is: " << midNum << endl;
	cout << "The largest number is: " << largeNum << endl;
	cout << "****************************************";

	return 0;
}	//end of main function