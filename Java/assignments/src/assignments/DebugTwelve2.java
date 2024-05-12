package assignments;

import java.util.Scanner;

public class DebugTwelve2
{
   public static void main(String[] args)
   {
      Scanner input = new Scanner(System.in);
      int x, y;
      final int GAP = 5;
      int answer;
      String userInput;
      System.out.print("Enter a number >> ");
      userInput = input.nextLine();
      x = Integer.parseInt(userInput);
      y = x + GAP;
      answer = sum(x, y);
      System.out.println("The sum of all the numbers between ");
      System. out.println("     " + x + " and " + y + " is " + answer);
   }
   public static int sum(int x, int y)
   {
      if(y > x) 
         return(y + sum(x, y - 1));
      else
         return y;
   }
}
