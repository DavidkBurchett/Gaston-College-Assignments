package assignments;
import java.util.Scanner;

public class Eggs {

	public static void main(String[] args) {
		Scanner inputDevice = new Scanner(System.in);
		int eggs = 0;
		
		System.out.print("Enter the amount of eggs: ");
		eggs = inputDevice.nextInt();
		
		int dozenAmount = eggs / 12;
		int remainingEggAmount = eggs % 12;
		double Cost = (dozenAmount * 3.25) + (remainingEggAmount * .45);
		
		System.out.print("You ordered ");
		System.out.print(eggs);
		System.out.println(" eggs.");
		System.out.print("That's ");
		System.out.print(dozenAmount);
		System.out.print(" dozen at $3.25 per dozen and ");
		System.out.print(remainingEggAmount);
		System.out.println(" loose eggs at 45 cents each.");
		System.out.print("For a total of $");
		System.out.print(Cost);
		System.out.print(".");
	}

}
