package assignments;

import java.util.Scanner;

/**
 * Purpose:  prompt user to add 9 ints in array, then print it
 * Author:   David Burchett
 * Date:     4/17/2023
 * Filename: NineInts.Java
 * Input:    9 ints
 * Output:   array forward and reversed 
 */
public class NineInts {

	public static void main(String[] args) {

		int[] arr = new int[9]; //create array
		int i;
		
		System.out.println("Enter 9 numbers for the array: ");
		Scanner inputDevice = new Scanner(System.in); //user input
		
		for(i = 0; i < 9; i++) {
			arr[i] = inputDevice.nextInt(); //add user input to array
		}
		
		inputDevice.close();

		System.out.println("forward"); //print forward
		for(i = 0; i < 9; i++) {
			System.out.print(arr[i]);
		}
		
		System.out.println("");
		
		System.out.println("reverse"); //print reverse
		for(i = 8; i > -1; i--) {
			System.out.print(arr[i]);
		}
	}

}
