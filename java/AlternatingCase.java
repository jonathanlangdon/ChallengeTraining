// flip the case of all characters in a string

public class AlternatingCase {

  public static String toAlternativeString(String str) {
    String newString = "";
    for (char c : str.toCharArray()) {
      if (Character.isUpperCase(c)) {
        newString += Character.toLowerCase(c);
      } else {
        newString += Character.toUpperCase(c);
      }
    }
    return newString;
  }

  public static void main(String[] args) {
    System.out.println(toAlternativeString("Hi")); // hI
    System.out.println(toAlternativeString("hI")); // Hi
    System.out.println(toAlternativeString("Hi3")); // hI3
  }
}