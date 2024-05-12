/*
	Made by: David Burchett
	Purpose: print various elements from an array
 */

fun main(){
	val scoreArray = arrayOf(100, 50, 90, 40, 100, 85, 95, 50, 0, 87); //create array
	
	println("All test scores");
	for (score in scoreArray) print("$score, ");
	
	println("\nThe average grade of all tests - ${scoreArray.average()}"); //display information to user
	println("\nThe first grade in the array - ${scoreArray[0]}");
	println("\nThe final grade in the array - ${scoreArray[9]}");
}