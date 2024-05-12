//Lab5-3.cpp - calculates and displays the total amount due
//Created/revised by David Kyle Burchett

#include <iostream>
#include <iomanip>    //so we can format output on the screen
using namespace std;

int main()
{	//declare and initialize variables and constants

	const double DISCOUNT_RATE = 0.10;
	const double MEMBER_DISCOUNT_RATE = 0.20;
	const double SHIP_CHG1 = 0.99;
	const double SHIP_CHG2 = 4.99;
	double total = 0.0;
	double grandTotal = 0.0;   //final total displayed to the user
	double amtOwed = 0.0;
	char member = ' ';   //are they a member of the Rhino club

	//enter input items
	cout << "Amount owed before any discount and shipping: $";   //prompt
	cin >> amtOwed;
	cout << "Rhino Club member (Y/N)? ";   //prompt
	cin >> member;

	//subtract discount, if appropriate
	if (toupper(member) == 'Y')
		total = amtOwed - (amtOwed * MEMBER_DISCOUNT_RATE);  //calculate the discounted total owed for members
	else
		total = amtOwed - (amtOwed * DISCOUNT_RATE);   //calculate the discounted total owed for non-members
	//end if

	//add shipping
	if (total >= 100.00)
		grandTotal = total + SHIP_CHG1;
	else
		grandTotal = total + SHIP_CHG2;
	//end if

	//display final amount owed
	cout << fixed << setprecision(2);   //sets the amount of numbers after the decimal
	cout << "Amount owed after any discount and shipping:  $" << grandTotal << endl;

	return 0;
}	//end of main function