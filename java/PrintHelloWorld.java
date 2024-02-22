public class PrintHelloWorld {
  public static class HelloWorld {
    static int[] charCodes = { 104, 101, 108, 108, 111, 32, 119, 111, 114, 108, 100, 33 };

    public static String greet() {
      StringBuilder sb = new StringBuilder();
      for (int letter : charCodes) {
        sb.append((char) letter);
      }
      return sb.toString();
    }

  }

  public static void main(String[] args) {
    System.out.println(HelloWorld.greet()); // "hello world!"
  }
}