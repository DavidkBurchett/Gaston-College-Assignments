package CollectionExcercise;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.Scanner;

public class ApartmentsLinkedList {

	public static void main(String[] args) {
		LinkedList<Apartment> aptList = new LinkedList<>();
		Iterator<Apartment> it = aptList.iterator();
		Scanner input = new Scanner(System.in);
		String userInput = ""; 
		String aptNumber, rent, bedrooms;
		
		while(true) {
			System.out.print("Enter street address for apartment or ZZZ to quit >> ");
			userInput = input.nextLine();
			if(userInput.equals("ZZZ")) {
				break;
			}
			System.out.print("Enter apartment number >> ");
			aptNumber = input.nextLine();
			System.out.print("Enter rent >> ");
			rent = input.nextLine();
			System.out.print("Enter number of bedrooms >> ");
			bedrooms = input.nextLine();
			Apartment apt = new Apartment(userInput, aptNumber, Double.parseDouble(rent), Integer.parseInt(bedrooms));
			
			aptList.add(apt);
		}
		
		while(it.hasNext()) {
			it.toString();
		}

	}

}
