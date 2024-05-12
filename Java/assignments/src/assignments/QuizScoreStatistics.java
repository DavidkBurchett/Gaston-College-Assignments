package assignments;

import java.util.Scanner;

/**
 * Purpose:  Calculate average of quiz scores
 * Author:   David Burchett
 * Date:     3/20/2023
 * Filename: QuizScoreStatistics.Java
 * Input:    variable number of doubles 0-10
 * Output:   average grade double
 */

public class QuizScoreStatistics {

	public static void main(String[] args) {
		
		System.out.print("Enter a quiz score (0-10), or 99 to quit: ");
		
		Scanner inputDevice = new Scanner(System.in); //user input
		double quizScore = inputDevice.nextInt(); //declare variables as doubles to make sure they are returned as doubles in the ends as well
		double counter = 0;
		double scoreSum = 0;

		while (quizScore != 99) {
			
			if (quizScore >= 0 && quizScore <=10) { //ensure it is within the correct range.
				counter += 1;
				scoreSum = scoreSum +  quizScore; //setup for finding average
				
				System.out.print("Enter a quiz score (0-10), or 99 to quit: ");
				quizScore = inputDevice.nextInt();
			} else {
				System.out.print("Enter a number between 0-10: ");
				quizScore = inputDevice.nextInt();
			}
					
		}
		inputDevice.close();
		double average = scoreSum / counter;
		System.out.println("The average score of the quizzes is " + average); //output
	}

}
