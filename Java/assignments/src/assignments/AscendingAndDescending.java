package assignments;

import java.util.Scanner;

/**
 * Purpose:  arrange 3 ints in ascending and descending order
 * Author:   David Burchett
 * Date:     3/13/2023
 * Filename: AscendingAndDescending.java
 * Input:    3 ints
 * Output:   2 outputs, one in ascending order, one in descending
 */

public class AscendingAndDescending {

	public static void main(String[] args) {
		int largest = 0; //Initialize variables
		int middle = 0;
		int smallest = 0;

		Scanner inputDevice = new Scanner(System.in); //user input
		
		System.out.print("Enter the first integer: "); //first int
		int input1 = inputDevice.nextInt();
		
		System.out.print("Enter the second integer: "); //second int
		int input2 = inputDevice.nextInt();
		
		System.out.print("Enter the third integer: "); //third int
		int input3 = inputDevice.nextInt();
		inputDevice.close();
		
		
		
		if (input1 > input2 && input1 > input3) { //testing if the first input is largest, then setting the middle and smallest in nested if
			largest = input1;
			
			if (input2 > input3) {
				middle = input2;
				smallest = input3;
			} else {
				middle = input3;
				smallest = input2;
			}
			
		} else if (input2 > input1 && input2 > input3) { //testing if the second input is largest, then setting the middle and smallest in nested if
			largest = input2;
			
			if (input1 > input3) {
				middle = input1;
				smallest = input3;
			} else {
				middle = input3;
				smallest = input1;
			}
			
		} else { //it is known that input3 is largest, so now we just find middle and smallest
			largest = input3;
			
			if (input1 > input2) {
				middle = input1;
				smallest = input2;
			} else {
				middle = input2;
				smallest = input1;
			}
		}
		
		System.out.println("The numbers in ascending order is: " + smallest + ", " + middle + ", " + largest);
		System.out.println("The numbers in descending order is: " + largest + ", " + middle + ", " + smallest);
	}
}
