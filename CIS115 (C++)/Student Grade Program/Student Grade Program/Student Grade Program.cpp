//Created by David Burchett on 11/6/2022
//Purpose is to calculate student averages with mid term and final grade scores of the students. Use this to display a letter grade and an average grade.

#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	//declare and init variables
	int midGrade = 0;
	int finalGrade = 0;
	char gradeFlag = ' '; // Y or N to flag continuing with the program
	double averageGrade = 0.0;
	char letterGrade = ' ';


	for (int i = 1; i <= 60; ++i) //60 header stars for top row
		cout << "*";

	cout << endl;
	cout << setw(40);
	cout << "Student Grades Program" << endl; //header

	for (int i = 1; i <= 60; ++i) //60 header stars for bottom row
		cout << "*";


	cout << endl << "Do you want to enter a student's grades? (Y or N) "; //first time asking to enter grades
	cin >> gradeFlag;
	gradeFlag = toupper(gradeFlag);


	while (gradeFlag == 'Y') {

		cout << "Enter the mid-term grade: "; //user enters grades
		cin >> midGrade;
		cout << "Enter the final grade: ";
		cin >> finalGrade;

		averageGrade = (midGrade + finalGrade) / 2.0; //calculate average
		cout << fixed << setprecision(1);
		cout << "The average of the grades is: " << averageGrade << endl;


		if (averageGrade >= 90) //display the letter grade
			cout << "The letter grade is: A";
		else if (averageGrade >= 80)
			cout << "The letter grade is: B";
		else if (averageGrade >= 70)
			cout << "The letter grade is: C";
		else if (averageGrade >= 60)
			cout << "The letter grade is: D";
		else 
			cout << "The letter grade is: F";// end if


		cout << endl << "Do you want to enter a student's grades? (Y or N) "; //second time asking to enter grades
		cin >> gradeFlag;
		gradeFlag = toupper(gradeFlag);

	}


	for (int i = 1; i <= 60; ++i) //60 closing stars for top row
		cout << "*";

	cout << endl;
	cout << setw(47);
	cout << "The Student Grades Program Has Ended" << endl; //closing statement

	for (int i = 1; i <= 60; ++i) //60 closing stars for bottom row
		cout << "*";

	return 0;
} //end of main function