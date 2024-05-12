package assignments;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class StudentsStanding {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in); 
		int id;
		String firstName, lastName;
		double gpa;
		
		try {
			
			File goodStanding = new File("StudentsGoodStanding.txt");
			goodStanding.createNewFile();
			BufferedWriter writeToGood = new BufferedWriter(new FileWriter("StudentsGoodStanding.txt"));
			
			File badStanding = new File("StudentsAcademicProbation.txt");
			badStanding.createNewFile();
			BufferedWriter writeToBad = new BufferedWriter(new FileWriter("StudentsAcademicProbation.txt"));
			
		
		
		while(true) {
			
			System.out.println("Enter student ID >> or ZZZ to quit");
			try{
				id = Integer.parseInt(input.nextLine());
			} catch(Exception e) {
				break;
			}
			System.out.println("Enter firstName >> ");
			firstName = input.nextLine();
			System.out.println("Enter last name >> ");
			lastName = input.nextLine();
			System.out.println("Enter grade point average >> ");
			gpa = Double.parseDouble(input.nextLine());
			
			if (gpa >= 2) {
				writeToGood.write(id + " " + firstName + " " + lastName + " " + gpa);
				writeToGood.newLine();
			} else {
				writeToBad.write(id + " " + firstName + " " + lastName + " " + gpa);
				writeToBad.newLine();
			}
		}
		writeToGood.close();
		writeToBad.close();
		input.close();
		} catch (IOException e) {
			System.out.println("exception occured");
			e.printStackTrace();
		}
	}

}
