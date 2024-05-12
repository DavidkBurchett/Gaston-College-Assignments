package multiclassExcerciseBooks;

public class NonFiction extends Book{

	NonFiction(String t) {
		super(t);
		
		setPrice();
	}
	
	public void setPrice() {
		this.price = 37.99;
	}
	
}
