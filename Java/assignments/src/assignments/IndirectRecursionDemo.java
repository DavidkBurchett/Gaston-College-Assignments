package assignments;

import java.util.Scanner;

public class IndirectRecursionDemo {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter an integer >> ");
		int num = input.nextInt();
		
		method1(num);
	}
	
	public static int method1(int num) {
		if(num > 0) {
			System.out.print(num + " ");
			return method2(num - 1);
		} else {
			return 0;
		}
	}
	
	public static int method2(int num) {
		if(num > 0) {
			System.out.print(num + " ");
			return method1(num - 1);
		} else {
			return 0;
		}
	}

}
