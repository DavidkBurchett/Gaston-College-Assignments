package assignments;

import java.util.*;

public class StringSortUserInput {

	public static void main(String[] args) {
		
		String[] Array = new String[15];
		
        Scanner inputDevice = new Scanner(System.in);
        System.out.println("Enter 15 strings to be sorted.");
        String userInput = inputDevice.next();
        Array[0] = userInput;
        int counter = 1;
		
        while (!userInput.contains("zzz") && counter < 15){
        	System.out.println("Enter the next string to be sorted.");
            userInput = inputDevice.next();
        	
        	Array[counter] = userInput;
        	counter += 1;

        }
		
        Array = Arrays.stream(Array)
                .filter(s -> (s != null && !s.contains("zzz") && s.length() > 0))
                .toArray(String[]::new);
        
		Arrays.sort(Array);
			
		for (String i : Array) { 
			System.out.print(i + " ");
		}
	}

}
