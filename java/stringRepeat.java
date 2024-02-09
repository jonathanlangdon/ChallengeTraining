// repeats a substring a number of times

public class stringRepeat {
  public static String repeatStr(final int numRepeat, final String subString) {
    return subString.repeat(numRepeat);
  }

  public static void main(String[] args) {
    System.out.println(repeatStr(3, "ha"));
  }
}