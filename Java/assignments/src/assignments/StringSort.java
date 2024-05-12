package assignments;

import java.util.*;

/**
 * Purpose:  sort an array of letters
 * Author:   David Burchett
 * Date:     5/1/2023
 * Filename: StringSort.Java
 * Input:    unsorted string array
 * Output:   sorted string array
 */

public class StringSort {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String[] letterArray = {"c", "e", "b", "d", "a"}; //create array unsorted
		
		
		Arrays.sort(letterArray); //sort
			
		for (String i : letterArray) { //print sorted array
			System.out.print(i + " ");
		}
	}

}
