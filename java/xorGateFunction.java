// create a function that acts like the XOR gate

public class xorGateFunction {
  public static boolean xor(boolean a, boolean b) {
    return a != b;
  }

  public static void main(String[] args) {
    System.out.println(xor(true, true)); // false
    System.out.println(xor(true, false)); // true
  }
}