//Created by David Burchett on 11/13/2022
//Purpose is to test my knowledge with use on all the loops that we have been taught.

#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	int count = 0; //starter star line for the program
	do {

		cout << "*";
		count += 1;

	} while (count < 30);

	cout << "\n \n \n \n";
	
	cout << "Creating the Chart Using Loops \n \n";

	int x = 1;
	while (x <= 5) { //loop to create the number chart
		
		for (int num = 1; num <= 5; num += 1)
			cout << setw(4) << left << (num * x);

		cout << "\n";
		x += 1;

	};

	cout << "\n \n \n";

	x = 1;
	string star = "";
	while (x <= 10) { //loop to create star triangle design

		for (int num = x; num >= x; x += 1)
			star += "*";
			cout << star << "\n";

	}

	cout << "\n \n \n";

	count = 0; //ending star line for the program
	do {

		cout << "*";
		count += 1;

	} while (count < 30);

return 0;
} //end of main function