package assignments;

import java.util.Scanner;


//Purpose:  Take a users name and print a thank you letter
//Author:   David Burchett
//Date:     2/20/2023
//Filename: FormLetterWriter.java
//Input:    First and last name as strings
//Output:   thank you letter

public class FormLetterWriter {

	public static void main(String[] args) {
		
		Scanner inputDevice = new Scanner(System.in); //start scanner and init variables 
		String firstName = "";
		String lastName = "";
		
		System.out.print("Enter your first name: "); //assign variables to user input
		firstName = inputDevice.nextLine();
		System.out.print("Enter your last name: ");
		lastName = inputDevice.nextLine();
		inputDevice.close(); //close scanner
		
		
		displaySalutation(lastName); //call methods with user input
		displaySalutation(firstName, lastName);
		
		
	}
	
	public static void displaySalutation(String last) { //last name only method
		
		System.out.println("Dear Mr. or Ms. " + last);
		System.out.println("Thank you for your recent order.");
		
	}
	
	public static void displaySalutation(String first, String last) { //first and last name method
		
		System.out.println("Dear " + first + " " + last);
		System.out.println("Thank you for your recent order.");
		
	}


}
