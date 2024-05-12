package multiclassExcerciseBooks;

public class Fiction extends Book{

	Fiction(String t) {
		super(t);
		
		setPrice();
	}
	
	public void setPrice() {
		this.price = 24.99;
	}

}
