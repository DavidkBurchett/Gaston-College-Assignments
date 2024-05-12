//Function.cpp - Displays answer based off chosen variable
//Created by David Burchett 0n 12/1/2022

#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

//declaring prototypes for functions
int addFun(int num1, int num2);
int subFun(int num1, int num2);
int powerFun(int num1, int num2);
double sqrtFun(int num1);
int multFun(int num1, int num2);
double divFun(int num1, int num2);
char selection();

int main()
{
    //decalaring variables
    int number1 = 0;
    int number2 = 0;



    char choice = selection();

    do { //this loop goes until the user enters x

        cout << endl << endl;

        if (choice != 'X')    //if the program is not eneding, ask for the two whole numbers
        {
            cout << "Enter first number: ";
            cin >> number1;

            cout << "Enter second number: ";
            cin >> number2;
        }//end if

        cout << endl;

    

        if (choice == 'A')//if statements begins for choices
        {
            cout << "Answer for Addition: " << addFun(number1, number2) << endl; //addition
        }
        else if (choice == 'S')
        {
            cout << "Answer for Subtraction: " << subFun(number1, number2) << endl; //subtraction
        }
        else if (choice == 'P')
        {
            cout << "Answer for Power: " << powerFun(number1, number2) << endl; //Raise to a power
        }
        else if (choice == 'R')
        {
            cout << "Answer for Square Root: " << sqrtFun(number1) << " " << sqrtFun(number2) << endl; //Square root
        }
        else if (choice == 'M')
        {
            cout << "Answer for Multiplication: " << multFun(number1, number2) << endl; //Multiply
        }
        else if (choice == 'D')
        {
            cout << "Answer for Division: " << divFun(number1, number2) << endl; //Divide
        }
        else
        {
            cout << endl << "This program has ended by user choice." << endl;
        }


        cout << "\n--------------------\n\n" ;


        choice = selection();


    } while (choice != 'X');


    return 0;
}//end of main function



//**** Functions ****
char selection() //this function allows the user to choose what function they want
{
    char choice = ' ';

    cout << "Choose A for Addition, S for Subtraction, P to raise to a power, R for square root, M for multiplication, or D for division" << endl;
    cout << "Choose X to exit program" << endl;

    cout << "Select your option: ";
    cin >> choice;

    return choice = toupper(choice);
}


int addFun(int addFuna, int addFunb)   //this functions adds two whole numbers
{
    return (addFuna + addFunb);
}


int subFun(int subFuna, int subFunb)   //this functions subtracts two whole numbers
{
    return (subFuna - subFunb);
}


int powerFun(int powerFuna, int powerFunb)   //this functions raises the first number to the power of the second number
{
    return (pow(powerFuna, powerFunb));
}


double sqrtFun(int sqrtFun)   //this functions finds the square root of a number
{
    return (sqrt(sqrtFun));
}


int multFun(int multFuna, int multFunb)   //this functions multiplies two whole numbers
{
    return (multFuna * multFunb);
}


double divFun(int divFuna, int divFunb)   //this functions divides two whole numbers
{
    return (divFuna / divFunb);
}