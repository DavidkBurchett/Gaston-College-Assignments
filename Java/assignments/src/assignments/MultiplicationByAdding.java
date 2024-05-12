package assignments;

import java.util.Scanner;

public class MultiplicationByAdding {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter an integer >> ");
		int num1 = input.nextInt();
		System.out.println("Enter another integer >> ");
		int num2 = input.nextInt();

		System.out.println(multiplication(num1, num2));
	}
	
	public static int multiplication(int x, int y) {
		
		if (x < y) {
	        return multiplication(y, x); 
		} else if (y != 0) {
	        return (x + multiplication(x, y - 1)); 
	    } else {
	        return 0; 
	    }
	}

}
