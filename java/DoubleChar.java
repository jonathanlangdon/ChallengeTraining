// manipulate strings to repeat characters once

public class DoubleChar {

  public static String doubleChar(String s) {
    StringBuilder newString = new StringBuilder();
    s.chars().forEach(c -> newString.append((char) c).append((char) c));
    return newString.toString();
  }

  public static void main(String[] args) {
    System.out.println(doubleChar("String")); // "SSttrriinngg"
  }
}