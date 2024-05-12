/*
	Made by: David Burchett
	Purpose: make a function to print a border with passed arguments
 */

fun main(){
	printBorder("=", 10);
	println("Happy Birthday, David!"); //call function with paramaters before and after birthday print
	printBorder("#",  15);
}

fun printBorder(symbol: String, timesToRepeat: Int){ //function to print border with iteration so it is variable
	for(count in timesToRepeat downTo 1){
		print("$symbol");
	}
	println()
}