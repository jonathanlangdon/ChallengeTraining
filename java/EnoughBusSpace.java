// returns whether there is space on a bus

public class EnoughBusSpace {

  public static int enough(int cap, int on, int wait) {
    int numNeedingRide = on + wait;
    return cap > numNeedingRide ? 0 : numNeedingRide - cap;
  }

  public static void main(String[] args) {
    System.out.println(enough(10, 5, 5)); // 0
    System.out.println(enough(100, 60, 50)); // 10
  }
}