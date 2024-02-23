public class AbbreviateName {
  public static String abbrevName(String name) {
    String first = name.substring(0, 1).toUpperCase();
    int lastIndex = name.indexOf(" ") + 1;
    String last = name.substring(lastIndex, lastIndex + 1).toUpperCase();
    return first + "." + last;
  }

  public static void main(String[] args) {
    System.out.println(abbrevName("john paul")); // "J.P"
  }
}

// second go using .split()

/*
 * public class AbbreviateName
 * {
 * public static String abbrevName(String name) {
 * String[] nameArr = name.split(" ");
 * return (nameArr[0].charAt(0) + "." + nameArr[1].charAt(0)).toUpperCase();
 * }
 * public static void main(String[] args) {
 * System.out.println(abbrevName("john paul")); // "J.P"
 * }
 * }
 * 
 */