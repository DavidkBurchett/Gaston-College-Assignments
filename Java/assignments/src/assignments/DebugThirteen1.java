package assignments;

import java.util.ArrayList;
import java.util.Scanner;
public class DebugThirteen1
{
   public static void main(String[] args)
   {
      Scanner kb = new Scanner(System.in);
      ArrayList<String> words = new ArrayList<String>();
      String word = "";
      final String QUIT = "ZZZ";
      System.out.print("Enter a word to store or " + QUIT +
         " to quit >> ");
      while(true)
      {
         word = kb.nextLine();
         if(word.equals(QUIT)) {
        	 break;
         }
         words.add(word);
         System.out.println("Current list : " + words);
         System.out.print("Enter a word to store or " + QUIT +
            " to quit >> ");
      }
   }
}
