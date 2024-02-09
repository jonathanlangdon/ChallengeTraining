// makes any number a negative

public class returnNegative {
  public static int makeNegative(final int x) {
    return x > 0 ? -1 * x : x;
  }

  public static void main(String[] args) {
    System.out.println(makeNegative(1)); // -1
    System.out.println(makeNegative(0)); // 0
    System.out.println(makeNegative(-13)); // -13
  }
}