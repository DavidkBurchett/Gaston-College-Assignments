//Lab7-1.cpp - calculates the average number of text using a while loop
//messages sent each day for 7 days
//Created/revised by David Burchett on 10/30/22

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int day = 1;
	int totalTexts = 0;
	int dailyTexts = 0;
	double average = 0.0;

	while (day < 8) //moving from for loop to while loop
	{
		cout << "How many text messages did you send on day " << day << "? ";
		cin >> dailyTexts;
		totalTexts += dailyTexts; //accumulate the total so the program can average
		day = day + 1;
	}	//end for

	average = static_cast<double>(totalTexts) / (day - 1);
	cout << fixed << setprecision(0);
	cout << endl << "You sent approximately "
		<< average << " text messages per day." << endl;
	return 0;
}   //end of main function