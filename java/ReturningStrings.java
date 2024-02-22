public class ReturningStrings {
  public static String greet(String name) {
    return "Hello, " + name + " how are you doing today?";
  }

  public static void main(String[] args) {
    System.out.println(greet("John"));
  }
}