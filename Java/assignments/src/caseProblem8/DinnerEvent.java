package caseProblem8;

//David Burchett
//Case problem 9

public class DinnerEvent extends Event{
	public final static String[] ENTREES = {"beef", "chicken", "fish", "pasta"};
	public final static String[] SIDES = {"salad", "mixed vegetables", "baked potato", "garlic bread", "dinner roll"};
	public final static String[] DESSERTS = {"chocolate cake", "apple pie", "butterscotch pudding"};
	
	private int entreeChoice, sideChoice1, sideChoice2, dessertChoice;
	
	public DinnerEvent(String num, int guests, int choice1, int choice2, int choice3, int choice4) {
		super(num, guests);
		if(choice1 < ENTREES.length) {
			entreeChoice = choice1;
		}
			else {
				entreeChoice = 0;
			}
		if(choice2 < SIDES.length) {
			sideChoice1 = choice2;
		}
			else {
				sideChoice1 = 0;
			}
		if(choice3 < SIDES.length) {
			sideChoice2 = choice3;
		}
			else {
				sideChoice2 = 0;
			}
		if(choice4 < DESSERTS.length) {
			dessertChoice = choice4;
		}
			else {
				dessertChoice = 0;
			}
	}
	
	public String getMenu() {
		return ENTREES[entreeChoice] + ", " + SIDES[sideChoice1] + ", " + SIDES[sideChoice2] + ", and " + DESSERTS[dessertChoice];
	}
	
}
