package assignments;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

public class RemoveNumber {

	public static void main(String[] args) {
		ArrayList<Integer> intArray = new ArrayList<Integer>(); 
		Iterator<Integer> it = intArray.iterator();
		Scanner input = new Scanner(System.in);
		
		String userInput = "";
		System.out.println("Enter integers or ZZZ to stop: ");
		
		while(true) {
			userInput = input.nextLine();
			if(userInput.equals("ZZZ")) {
				break;
			}
			intArray.add(Integer.parseInt(userInput));
		}
		
		System.out.println("Numbers: ");
		
		for(Integer num : intArray) {
			System.out.print(num + " ");
		}
		
		System.out.println("Enter a number to eliminate: ");
		while (it.hasNext()){
			Integer i = it.next();
			
			if(Integer.parseInt(userInput) == i) {
				it.remove();
				break;
			}
		}
		
		System.out.println("Numbers: ");
		
		for(Integer num : intArray) {
			System.out.print(num + " ");
		}
	}

}
