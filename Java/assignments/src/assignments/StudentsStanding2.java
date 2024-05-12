package assignments;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class StudentsStanding2 {

	public static void main(String[] args) {
		
		try {
			File badStanding = new File("StudentsAcademicProbation.txt");
			Scanner badStandingReader = new Scanner(badStanding);
			
			File goodStanding = new File("StudentsGoodStanding.txt");
			Scanner goodStandingReader = new Scanner(goodStanding);
			
			System.out.println("Probationary Standing");
			while (badStandingReader.hasNextLine()) {
				System.out.println(badStandingReader.nextLine());
			}
			
			while (goodStandingReader.hasNextLine()) {
				System.out.println(goodStandingReader.nextLine());
			}
			
			badStandingReader.close();
			goodStandingReader.close();
		} catch (FileNotFoundException e) {
			System.out.println("exception occured");
			e.printStackTrace();
		}
		
	}

}
