package exceptionHandlingExcercise;

public class CourseException extends Exception{

	CourseException(String department){
		System.out.println("Department code number must be three characters ");
	}

}
