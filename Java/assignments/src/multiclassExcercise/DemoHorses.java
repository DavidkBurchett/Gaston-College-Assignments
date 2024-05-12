package multiclassExcercise;

import java.util.Scanner;

public class DemoHorses {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Horse userHorse = new Horse();
		RaceHorse userRaceHorse = new RaceHorse();
		
		System.out.println("Enter name for horse >> ");
		userHorse.setName(input.nextLine());
		System.out.println("Enter color for " + userHorse.getName() + " >> ");
		userHorse.setColor(input.nextLine());
		System.out.println("Enter year of birth >> ");
		userHorse.setBirthYear(Integer.parseInt(input.nextLine()));
		
		
		System.out.println("Enter name for race horse >> ");
		userRaceHorse.setName(input.nextLine());
		System.out.println("Enter color for " + userRaceHorse.getName() + " >> ");
		userRaceHorse.setColor(input.nextLine());
		System.out.println("Enter year of birth >> ");
		userRaceHorse.setBirthYear(Integer.parseInt(input.nextLine()));
		System.out.println("Enter number of races for " + userRaceHorse.getName() +" >> ");
		userRaceHorse.setRaces(Integer.parseInt(input.nextLine()));
		
		
		System.out.println(String.format("%1$s is %2$s and was born in %3$s.", userHorse.getName(), userHorse.getColor(), userHorse.getBirthYear()));
		System.out.println(String.format("%1$s is %2$s and was born in %3$s.", userRaceHorse.getName(), userRaceHorse.getColor(), userRaceHorse.getBirthYear()));
		System.out.println(String.format("%1$s has been in %2$s races.", userRaceHorse.getName(), userRaceHorse.getRaces()));
		
	}
	
}
