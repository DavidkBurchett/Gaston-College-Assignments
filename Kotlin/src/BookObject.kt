/*open class Books(
	open var name: String = "",
	open var authorLast: String = "",
	open var yearPublished: Int = 0){
	
	override fun toString(): String = "$name was made by $authorLast in year $yearPublished";
}

class Fiction(
	override var name: String = "",
	override var authorLast: String = "",
	override var yearPublished: Int = 0) : Books(){
	
	override fun toString(): String = "$name was made by $authorLast in year $yearPublished, which is a fiction book";
}

class NonFiction(
	override var name: String = "",
	override var authorLast: String = "",
	override var yearPublished: Int = 0) : Books(){
	
	override fun toString(): String = "$name was made by $authorLast in year $yearPublished, which is a nonfiction book";
}

fun main(){
	var book1 = Fiction("book1", "author1", 1);
	var book2 = NonFiction("book2", "author2", 2);
	var book3 = Fiction("book3", "author3", 3);
	var book4 = NonFiction("book4", "author4", 4);
	var book5 = Books("book5", "author5", 5);
	
	println(book1);
	println(book2);
	println(book3);
	println(book4);
	println(book5);
	println("This program has ended successfully.");
}*/