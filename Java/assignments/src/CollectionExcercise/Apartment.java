package CollectionExcercise;

public class Apartment implements Comparable<Apartment> {

	public String aptNumber, address;
	public int bedrooms;
	public double rent;
	
	public Apartment(String address, String aptNumber, double rent, int bedrooms ) {
		this.address = address;
		this.aptNumber = aptNumber;
		this.rent = rent;
		this.bedrooms = bedrooms;
	}
	
	@Override
	public String toString() {
		return address + " Apt number " + aptNumber + "\n Rent " + rent + " " + bedrooms + " bedrooms";
	}
	

	@Override
	public int compareTo(Apartment o) {
		
		if (this.rent > o.rent) {
			 
            // if current object is greater,then return 1
            return 1;
        }
        else if (this.rent < o.rent) {
 
            // if current object is greater,then return -1
            return -1;
        }
        else {
 
            // if current object is equal to o,then return 0
            return 0;
            
        }
	}
}
