package multiclassExcerciseCandles;

import java.util.Scanner;

public class DemoCandles {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Candle userCandle = new Candle();
		ScentedCandle userScentedCandle = new ScentedCandle();
		
		System.out.println("Enter a color for the candle >> ");
		userCandle.setColor(input.nextLine());
		System.out.println("Enter a height in a whole number of inches >> ");
		userCandle.setHeight(Integer.parseInt(input.nextLine()));
		
		
		System.out.println("Enter a color for the scented candle >> ");
		userScentedCandle.setColor(input.nextLine());
		System.out.println("Enter a height in a whole number of inches >> ");
		userScentedCandle.setHeight(Integer.parseInt(input.nextLine()));
		System.out.println("Enter a scent. Choose from the following: gardenia, beach, pine, carnation     >> ");
		userScentedCandle.setScent(input.nextLine());
		
		System.out.println(String.format("The %1$s inch %2$s candle costs $%3$s.", userCandle.getHeight(), userCandle.getColor(), userCandle.getPrice()));
		System.out.println(String.format("The %1$s inch %2$s %3$s candle costs $%4$s.", userScentedCandle.getHeight(), userScentedCandle.getColor(), userScentedCandle.getScent(), userScentedCandle.getPrice()));
	}
}
