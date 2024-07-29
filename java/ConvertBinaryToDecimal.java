// convert binary number to decimal

public class ConvertBinaryToDecimal {
  public static int binToDecimal(String binaryStr) {
    return Integer.parseInt(binaryStr, 2);
  }

  public static void main(String[] args) {
    System.out.println(binToDecimal("1101")); // 13
  }
}