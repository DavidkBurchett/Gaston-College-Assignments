package multiclassExcerciseCandles;

public class Candle {
	
	public String color;
	public int height;
	public double price;
	
	public String getColor() {
		return color;
	}
	
	public void setColor(String color) {
		this.color = color;
	}
	
	public int getHeight() {
		return height;
	}
	
	public void setHeight(int height) {
		this.height = height;
		this.price = height * 2;
	}
	
	public double getPrice() {
		return price;
	}
}
