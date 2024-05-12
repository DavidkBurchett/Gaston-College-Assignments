//Lab4-4.cpp - displays the volume of a cylinder
//Created/revised by David Kyle Burchett on 9/21/22
//Revisions made to make program work

#include <iostream>
using namespace std;

int main()
{
	//declare and initialize variables and constants
	double height = 0.0;
	double radius = 0.0;
	double volume = 0.0;
	const double PI = 3.14;

	//Ask the user to enter the needed data
	cout << "Height: ";
	cin >> height;

	cout << "Radius: "; //Added prompt for radius
	cin >> radius; //Pulls radius value from screen

	//Calculate and display the volume
	volume = PI * radius * radius * height;
	cout << "Volume: " << volume << endl;

	return 0;
} //end of main function