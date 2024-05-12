/*
	Made by: David Burchett
	Purpose: create a right triangle with loops
 */

fun main(){
	
	var x = 0; //create variables
	var y = 0;
	var hashtag = "";
	
	while(x < 6){
		while(y < 6){
			hashtag += "#"
			println("$hashtag"); //print the hashtags
			y++
		}
		x++
	}
}