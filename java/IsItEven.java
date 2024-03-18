// return whether a number is even

public class IsItEven {

  public static boolean isEven(double n) {
    return n % 2 == 0;
  }

  public static void main(String[] args) {
    System.out.println(isEven(4)); // true
    System.out.println(isEven(7)); // false
  }
}