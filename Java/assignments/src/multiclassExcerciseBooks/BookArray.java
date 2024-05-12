package multiclassExcerciseBooks;

import java.util.Scanner;

public class BookArray {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Book bookArray[] = new Book[10];
		String titleEntry, fictionEntry;

		for(int i = 0; i < 10; i++) {
			System.out.print("Enter Title >> ");
			titleEntry = input.nextLine();		
			
			System.out.print("Is this a (F)iction or (N)onfiction title? >> ");
			fictionEntry = input.nextLine().toUpperCase();	
			if (fictionEntry.equals("F")) {
				bookArray[i] = new Fiction(titleEntry);
			} else if (fictionEntry.equals("N")){
				bookArray[i] = new NonFiction(titleEntry);
			} else {
				System.out.println("Enter either F or N");
			}
		}
		
		for(int i = 0; i < 10; i++) {
			System.out.println(String.format("Book: %1$s costs %2$s.", bookArray[i].getTitle(), bookArray[i].getPrice()));
		}
	}
	
}
