package assignments;

import java.util.Scanner;

/**
 * Purpose:  prompt user enter even numbers as much as they want
 * Author:   David Burchett
 * Date:     3/20/2023
 * Filename: EvenEntryLoop.Java
 * Input:    1 int, repeatable
 * Output:   success/failure message
 */

public class EvenEntryLoop {

	public static void main(String[] args) {
		
		System.out.print("Enter an even number, or 999 to quit: ");
		
		Scanner inputDevice = new Scanner(System.in); //user input
		int userInput = inputDevice.nextInt();
		
		
		while (userInput != 999) { //loop
			
			int isEven = userInput % 2; //check if even
		
			switch (isEven) { //give outputs based on input
				case 0:
					System.out.println("Good Job!");
					break;
				case 1:
					System.out.println("Enter an Even Number.");
					break;
			}
			
			userInput = inputDevice.nextInt();
			
		}
		inputDevice.close();
	}

}
