// convert a speed in km/h into cm/speed

public class CockroachSpeed {

  public static int cockroachSpeed(double x) {
    return (int) (x * 100000 / 3600);
  }

  public static void main(String[] args) {
    System.out.println(cockroachSpeed(1.08)); // 30
    System.out.println(cockroachSpeed(1.07)); // 29
    System.out.println(cockroachSpeed(1.05)); // 29
  }
}

/*
 * The cockroach is one of the fastest insects. Write a function which takes its
 * speed in km per hour and returns it in cm per second, rounded down to the
 * integer (= floored).
 * 
 * For example:
 * 
 * 1.08 --> 30
 * 
 * Note! The input is a Real number (actual type is language dependent) and is
 * >= 0. The result should be an Integer.
 */