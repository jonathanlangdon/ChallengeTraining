public class EvenOddMultiply {
  public static int simpleMultiplication(int n) {
    return n % 2 == 0 ? n * 8 : n * 9;
  }

  public static void main(String[] args) {
    System.out.println(simpleMultiplication(21)); // 189
    System.out.println(simpleMultiplication(4)); // 32
  }
}
