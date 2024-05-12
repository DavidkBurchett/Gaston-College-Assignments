package assignments;

import java.util.Scanner;

/**
 * Purpose:  determine if integer is even or odd
 * Author:   David Burchett
 * Date:     3/13/2023
 * Filename: EvenOdd.java
 * Input:    1 int
 * Output:   statement of even or odd
 */
public class EvenOdd {

	public static void main(String[] args) {
		
		Scanner inputDevice = new Scanner(System.in); //user input
		System.out.print("Enter an integer: "); 
		int input = inputDevice.nextInt();
		inputDevice.close();

		if (input % 2 == 0) {
			System.out.println("It is even"); //output if even
		} else {
			System.out.println("It is odd"); //output if odd
		}
	}
}
