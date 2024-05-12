package multiclassExcerciseBooks;

import java.util.Scanner;

public class UseBook {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		
		
		System.out.print("Enter fiction book title >> ");
		Fiction userFiction = new Fiction(input.nextLine());
		
		System.out.print("Enter nonfiction book title >> ");
		NonFiction userNonFiction = new NonFiction(input.nextLine());
		
		System.out.println(String.format("Fiction %1$s costs %2$s.", userFiction.getTitle(), userFiction.getPrice()));
		System.out.println(String.format("Non-Fiction %1$s costs %2$s.", userNonFiction.getTitle(), userNonFiction.getPrice()));
	}
	
}
