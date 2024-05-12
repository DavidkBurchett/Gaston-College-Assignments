package assignments;

import java.util.Scanner;

/**
 * Purpose:  find average and distance from the distance of each number
 * Author:   David Burchett
 * Date:     4/17/2023
 * Filename: DistanceFromAverage.Java
 * Input:    15 doubles
 * Output:   all of the 15 doubles as well as distance from average of each
 */

public class DistanceFromAverage {

	public static void main(String[] args) {
		
		double[] arr = new double[15]; //create array
		int i;
		double total =  0;
		
		System.out.println("Enter 15 numbers for the array (99999 to quit): ");
		Scanner inputDevice = new Scanner(System.in); //user input
		
		for(i = 0; i < 15; i++) {
			double currentNum = inputDevice.nextDouble();
			if (currentNum == 99999) { //check for early quit
				break;
			}
			arr[i] = currentNum; //add user input to array
			total += currentNum;
		}
		
		inputDevice.close();

		if (total != 0) { //check if no numbers are entered
		
			double average = total / i; //find average
			
			for(i = 0; i < 15; i++) { //print for user
				if (arr[i] == 0) { //end early if empty cell
					break;
				}
				System.out.println("number: " + arr[i]);
				System.out.println("distance from average: " + (arr[i] - average));
				System.out.println("------------");
			}
		} else {
			System.out.println("Enter at least one number"); //error
		}
	}

}
