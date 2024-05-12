package exceptionHandlingExcercise;

public class Course {
	
	private String department;
	private int courseNumber;
	private double credits;
	
	Course(){
		this.department = "";
		this.courseNumber = 0;
		this.credits = 0;
	}
	
	Course(String dept, int num, double cred ) throws CourseException{
		
		if(dept.length() != 3) {
			throw new CourseException(dept);
		} else {
			this.department = dept;
		}
		
		if(num <= 100 && num >= 499) {
			throw new CourseException(dept);
		} else {
			this.courseNumber = num;
		}
		
		if(cred < .5 && num > 6) {
			throw new CourseException(dept);
		} else {
			this.credits = cred;
		}
				
	}
	
	@Override
	public String toString() {
		return this.department + this.courseNumber + " Credits " + this.credits;
	}

}
