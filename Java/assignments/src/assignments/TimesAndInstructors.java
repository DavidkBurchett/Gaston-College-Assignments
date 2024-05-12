package assignments;

import java.util.Scanner;

public class TimesAndInstructors {
	
	public static void main(String[] args) {
		
		String courses[][] = new String[5][3];
		  courses[0][0] = "CIS101";
	      courses[0][1] = "Mon 9am";
	      courses[0][2] = "Kahn";
	      courses[1][0] = "CIS210";
	      courses[0][1] = "Mon 11 am";
	      courses[1][2] = "Patel";
	      courses[2][0] = "MKT100";
	      courses[2][1] = "Tues 8:30 am";
	      courses[2][2] = "Wong";
	      courses[3][0] = "ACC150";
	      courses[3][1] = "Tues 6 pm";
	      courses[3][2] = "Deitrich";
	      courses[4][0] = "CIS101";
	      courses[4][1] = "Fri 1 pm";
	      courses[4][2] = "Lennon";
	      
	      Scanner inputDevice = new Scanner(System.in);
	      
	      whileloop:
	      while(true) {
	    	  
	    	  System.out.println("Enter a course.");
		      String userInput = inputDevice.next();
		      
	    	  for (int i = 0; i < courses.length; i++) {
		            for (int j = 0; j < courses[i].length; j++) {
		            	if (courses[i][j] != null) {
		            		if (courses[i][j].contentEquals(userInput)) {
			                	System.out.println("Course: " + courses[i][j] + " Time: " + courses[i][j+1] + " Instructor: " + courses[i][j+2]);
			                	if (courses[i][j].contentEquals("CIS101")) {
			                		System.out.println("Course: " + courses[4][j] + " Time: " + courses[4][j+1] + " Instructor: " + courses[4][j+2]);
		            			}
			            		break whileloop;
			                }
		            	}
		            }
		        }
	    	  System.out.println("Enter a proper course.");
	      }    
	}
}
