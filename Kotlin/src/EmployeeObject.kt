/*
	Made by: David Burchett
	Purpose: make a employee class with 5 fields
 */

class Employee(
	var name: String = "",
    var age: Int = 0,
    var gender: Char = 'M',
    var salary: Double = 0.toDouble(),
	var currentlyEmployed: Boolean = true){
	
	fun insetValues(name: String, age: Int, gender: Char, salary: Double, currentlyEmployed: Boolean){ //set object values to specified input
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.salary = salary;
		this.currentlyEmployed = currentlyEmployed;
		println("name = $name \nage = $age \ngender = $gender \nsalary = $salary \ncurrently employed = $currentlyEmployed") //print values to console
	}
	
}

fun main(){
	var obj = Employee();
	var obj2 = Employee();
	var obj3 = Employee();
	
	println("employee 1 \n----------")
	obj.insetValues("Ford", 50, 'F', 45000.00, true); //input values into the object fields
	println("\nemployee 2 \n----------")
	obj2.insetValues("James", 35, 'M', 40000.00, true);
	println("\nemployee 3 \n----------")
	obj3.insetValues("todd", 65, 'M', 60000.0, false);
}
