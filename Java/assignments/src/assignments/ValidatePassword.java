package assignments;

import java.util.Scanner;

/**
 * Purpose:  prompt user to make a valid password
 * Author:   David Burchett
 * Date:     4/3/2023
 * Filename: ValidatePassword.Java
 * Input:    a password
 * Output:   message claiming whether it is valid or not
 */

public class ValidatePassword {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		System.out.println("Enter a password that has at least two uppercase letters, at least three lowercase letters, and at least one digit.");
		Scanner inputDevice = new Scanner(System.in); //user input
		String password = inputDevice.next();
		inputDevice.close();
		
		checkPassword(password);//call method
	}
	
	public static void checkPassword(String password) { 
		int digits = 0;
		int upperCase = 0;
		int lowerCase = 0;
		char currentLetter;
		for(int i=0; i < password.length();i++) { //count the digits and uppercase/lowercase letters
			currentLetter = password.charAt(i);
			if (Character.isDigit(currentLetter)) {
				++digits;
			} else if (Character.isUpperCase(currentLetter)) {
				++upperCase;
			} else if (Character.isLowerCase(currentLetter)) {
				++lowerCase;
			}
		}
		
		if(digits >= 1 && upperCase >= 2 && lowerCase >= 3) { //check if it matches the specifications
			System.out.println("That password is valid");
		} else {
			System.out.println("Your password only has " + digits + " digits, " + upperCase + " uppercase letters, and " + lowerCase + " lowercase letters.");
		}
	}

}
