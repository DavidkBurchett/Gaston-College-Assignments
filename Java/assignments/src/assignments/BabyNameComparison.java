package assignments;

import java.util.Scanner;

/**
 * Purpose:  compare baby names
 * Author:   David Burchett
 * Date:     4/3/2023
 * Filename: BabyNameComparison.Java
 * Input:    3 names
 * Output:   the names concatinated
 */

public class BabyNameComparison {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		System.out.println("Enter 3 baby names");
		Scanner inputDevice = new Scanner(System.in); //user input
		String name1 = inputDevice.next();
		String name2 = inputDevice.next();
		String name3 = inputDevice.next();
		inputDevice.close();
		
		System.out.println(nameConcat(name1, name2)); //print the names
		System.out.println(nameConcat(name2, name1));
		System.out.println(nameConcat(name1, name3));
		System.out.println(nameConcat(name3, name1));
		System.out.println(nameConcat(name2, name3));
		System.out.println(nameConcat(name3, name2));
	}
	
	public static String nameConcat(String name1, String name2) { //method to concat names
		return name1.concat(" " + name2);
	}

}
