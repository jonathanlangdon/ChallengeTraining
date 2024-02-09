// removes first and last character of a string

public class removeFirstLast {
  public static String remove(String str) {
    return str.substring(1, str.length() - 1);
  }

  public static void main(String[] args) {
    System.out.println(remove("hello"));
  }
}
