package multiclassExcerciseBooks;

public abstract class Book {
	
	String title;
	Double price;
	
	Book(String t){
		title = t;
	}
	
	public String getTitle() {
		return title;
	}
	
	public Double getPrice() {
		return price;
	}
	
}
