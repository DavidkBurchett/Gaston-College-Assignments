package exceptionHandlingExcercise;

import java.util.Scanner;

public class ThrowCourseException {

	public static void main(String[] args) {
		Scanner userInput = new Scanner(System.in);
		Course[] courseArray = new Course[6];
		String userCourse;
		int userNum, counter = 1;
		double userCredits;
		

		for (int i = 0; i < 6; i++) {
			try {
				System.out.println("Enter course " + counter + " department");
				userCourse = userInput.nextLine();
				while (true) {
					try {
						System.out.println("Enter course " + counter + " number");
						userNum = Integer.parseInt(userInput.nextLine());
						break;
					} catch(Exception e){
						continue;
					}
				}
				while (true) {
					try {
						System.out.println("Enter course " + counter + " credits");
						userCredits = Double.parseDouble(userInput.nextLine());
						break;
					} catch(Exception e){
						continue;
					}
				}
				courseArray[i] = new Course(userCourse, userNum, userCredits);
				counter += 1;
			} catch(CourseException e) {
				courseArray[i] = new Course();
				counter += 1;
			}
		}
		
		for (int i = 0; i < 6; i++) {
			System.out.println(courseArray[i].toString());
		}
		
	}

}
