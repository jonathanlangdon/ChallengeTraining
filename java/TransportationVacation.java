// returns cost of renting car

public class TransportationVacation {

  public static int rentalCarCost(int d) {
    int costPerDay = 40;
    int total = d * costPerDay;
    if (d >= 7) total -= 50;
    else if (d >= 3) total -= 20;
    return total;
  }

  public static void main(String[] args) {
    System.out.println(rentalCarCost(2)); // 80 
    System.out.println(rentalCarCost(3)); // 100 
    System.out.println(rentalCarCost(6)); // 220
    System.out.println(rentalCarCost(7)); // 230
  }
}

/*
After a hard quarter in the office you decide to get some rest on a vacation. So you will book a flight for you and your girlfriend and try to leave all the mess behind you.

You will need a rental car in order for you to get around in your vacation. The manager of the car rental makes you some good offers.

Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total. Alternatively, if you rent the car for 3 or more days, you get $20 off your total.

Write a code that gives out the total amount for different days(d).

 */
