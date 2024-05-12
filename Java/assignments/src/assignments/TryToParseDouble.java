package assignments;

import java.util.Scanner;

class TryToParseDouble {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double entry;
		
		System.out.print("Enter a double: ");
		
		try {
			entry = Double.parseDouble(input.nextLine());
		} catch(Exception e) {
			entry = 0.0;
			System.out.println("Value entered cannot be converted to a floating-point number");
		}
		
		System.out.println("Number is " + entry);
	}

}
