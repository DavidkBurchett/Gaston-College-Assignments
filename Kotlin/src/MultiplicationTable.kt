/*
	Made by: David Burchett
	Purpose: Print a multiplication table
 */

fun main() {
	
	var row = 1; //create variables
	var column = 1;
	
	while (row <= 5){
		while (column <= 10){
			
			print("${row * column}\t"); //print the multiplication
			column += 1;
		}
		println();
		column = 1; //reset the column to iterate again
		row += 1;
	}
}