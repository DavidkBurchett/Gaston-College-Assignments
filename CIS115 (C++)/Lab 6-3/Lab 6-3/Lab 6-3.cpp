//Lab6-2.cpp - displays the price of a pizza 
//Created/revised by David Burchett on 10/13/22

#include <iostream>
#include <iomanip> //for formatting numbers to the screen
using namespace std;

int main()
{
	//declare variables
	char size = ' ';
	char coupon = ' ';
	double price = 0.0;
	const double COUPON = 2.00;

	//ask the user for the pizza size
	cout << "M(edium) or L(arge) pizza? ";
	cin >> size;
	size = toupper(size);

	//determine the cost of the pizza
	if (size != 'M' && size != 'L')
		cout << "Please enter either M or L." << endl;
	else
	{
		
			price = 12.99; //ask for coupon
			cout << "$2 coupon (Y/N)? ";
			cin >> coupon;
			coupon = toupper(coupon);

			if (coupon == 'Y' && size == 'M') //convert to uppercase for comparasion
				price = 9.99 - COUPON;
			else if (coupon == 'Y' && size == 'L')
				price = 12.99 - COUPON;
			else if (coupon == 'N' && size == 'M')
				price = 9.99; // medium pizza without discount
			else
				price = 12.99; // large pizza without discount

		cout << fixed << setprecision(2);
		cout << "Price: $" << price << endl;
	} //end if

	return 0;
}	//end of main function