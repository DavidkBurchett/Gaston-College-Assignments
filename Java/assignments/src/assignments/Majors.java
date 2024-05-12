package assignments;

import java.util.Scanner;

/**
 * Purpose:  print majors divisions based off of enums
 * Author:   David Burchett
 * Date:     5/1/2023
 * Filename: Majors.Java
 * Input:    Major abbreviation
 * Output:   division of the requested major
 */

public class Majors {
	
	enum majors {
		ACC,
		CHEM, 
		CIS, 
		ENG, 
		HIS, 
		PHYS
	}
	
	public static void main(String[] args) {
		
		System.out.print("Please select one of the avaiable majors: "); //printing majors to user
		for (majors myVar : majors.values()) {
			  System.out.print(myVar+ " ");
			}
		
		Scanner inputDevice = new Scanner(System.in); //user input
		System.out.println("");
		String selection = inputDevice.next();
		inputDevice.close();
		
		switch(selection.toUpperCase()) { //find user selection
		case "ACC":
		case "CIS":
			System.out.println("Buisness Division"); 
			break;
			
		case "CHEM":
		case "PHYS":
			System.out.println("Science Division");
			break;
			
		case "ENG":
		case "HIS":
			System.out.println("Humanities Division");
			break;
			
		default:
			System.out.println("Please enter a valid major"); //bad input handling
			break;
		}
		
		}
}
