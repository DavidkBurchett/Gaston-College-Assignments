package caseProblem8;

//David Burchett
//Case problem 9

import java.util.Scanner;
public class EventDemo
{
   public static void main(String[] args)
   {
      String eventNum;
      int guests, option, x;
      final int SENTINEL = 999;
      Event[] events = new Event[8];
      
      for(x = 0; x < events.length; ++x) {
    	  eventNum = getEventNumber();
    	  guests = getGuests();
    	  events[x] = new Event(eventNum, guests);
    	  events[x].setContactPhone(getPhone());
    	  events[x].setEventType(getType());
      }
      System.out.println("\n\nNow display the events");
      option = getOption(SENTINEL);
      while(option != SENTINEL) {
    	  if(option == 1) {
    		  sortByEventNumber(events);
    	  }
    	  else {
    		  if(option == 2)
    			  sortByGuests(events);
    		  else {
    			  if(option == 3) {
    				  sortByType(events);
    			  }
    			  else {
    				  System.out.println("Enter 1, 2, or 3");
    			  }
    		  }
    	  }
    	  option = getOption(SENTINEL);
      } 
   }
   
   public static int getOption(final int SENTINEL) {
	   Scanner input = new Scanner(System.in);
	   int option;
	   System.out.println("\nPlease enter an option");
	   System.out.print("   1 - by event number\n   2 - by number of guests\n   3 - by event type\n   " + SENTINEL + " - to quit     >> ");
	   option = input.nextInt();
	   input.nextLine();
	   return option;
   }
   
   public static void sortByEventNumber(Event[] array) {
	   int a,b;
	   Event temp;
	   String stringB, stringBPlus;
	   int highSubscript = array.length - 1;
	   
	   for(a = 0; a < highSubscript; ++a) {
		   for(b = 0; b < highSubscript; ++b) {
			   stringB = array[b].getEventNumber();
			   stringBPlus = array[b + 1].getEventNumber();
			   
			   if(stringB.compareTo(stringBPlus) > 0) {
				   temp = array[b];
				   array[b] = array [b +1];
				   array[b + 1] = temp;
			   }
		   }
	   }
	   for(a = 0; a < array.length; ++a) {
		   displayDetails(array[a]);
	   }
   }
   
   public static void sortByGuests(Event[] array) {
	   int a,b;
	   Event temp;
	   int highSubscript = array.length - 1;
	   
	   for(a = 0; a < highSubscript; ++a) {
		   for(b = 0; b < highSubscript; ++b) {
			   if(array[b].getGuests() > array[b + 1].getGuests()) {
				   temp = array[b];
				   array[b] = array [b +1];
				   array[b + 1] = temp;
			   }
		   }
	   }
	   for(a = 0; a < array.length; ++a) {
		   displayDetails(array[a]);
	   }
   }
   
   public static void sortByType(Event[] array) {
	   int a,b;
	   Event temp;
	   int highSubscript = array.length - 1;
	   
	   for(a = 0; a < highSubscript; ++a) {
		   for(b = 0; b < highSubscript; ++b) {
			   if(array[b].getEventType() > array[b + 1].getEventType()) {
				   temp = array[b];
				   array[b] = array [b +1];
				   array[b + 1] = temp;
			   }
		   }
	   }
	   for(a = 0; a < array.length; ++a) {
		   displayDetails(array[a]);
	   }
   }
   
   public static String getEventNumber()
   {
      String num;
      Scanner input = new Scanner(System.in);
      System.out.print("Enter event number >> ");
      num = input.nextLine();
      return num;
   }  
   public static int getGuests()
   {
      int guests;
      final int MIN_GUESTS = 5;
      final int MAX_GUESTS = 100;
      Scanner input = new Scanner(System.in);
      System.out.print("Enter number of guests >> ");
      guests = input.nextInt();
      while(guests < MIN_GUESTS || guests > MAX_GUESTS)
      {
         System.out.println("The number of guests must be between " +
            MIN_GUESTS + " and " + MAX_GUESTS);
         System.out.print("Please re-enter >> ");
         guests = input.nextInt();
      } 
      input.nextLine();
      return guests;
   }
   public static int getType() {
	   int eType;
	   Scanner input = new Scanner(System.in);
	   System.out.println("Event types are");
	   for(int x = 0; x < Event.EVENT_TYPES.length; ++x) {
		   System.out.println("   " + x + " " + Event.EVENT_TYPES[x]);
	   }
	   System.out.print("Enter event type >> ");
	   eType = input.nextInt();
	   return eType;
   }
   public static void displayDetails(Event e)
   {
      System.out.println("\nEvent #" + e.getEventNumber());
      System.out.println("The price for an event with " + e.getGuests() + " guests at $" + e.getPricePerGuest() + " per guest is $" + e.getPriceForEvent());
      System.out.println("Whether this is a large event is " + (e.getGuests() >= e.LARGE_EVENT));
      System.out.println("Contact phone number is: " + e.getContactPhone());
      System.out.println("The event is type " + e.getEventType() + " which is the following type: " + e.getEventTypeString());
   }
   public static String getPhone()
   {
      String phone;
      Scanner input = new Scanner(System.in);
      System.out.print("Enter contact phone number >> ");
      phone = input.nextLine();
      return phone;
   } 
}
