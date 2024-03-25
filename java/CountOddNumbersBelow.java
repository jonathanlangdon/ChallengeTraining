// return how many odd numbers are below an input numbers

public class CountOddNumbersBelow {

  public static int oddCount(int n) {
    return n / 2;
  }

  public static void main(String[] args) {
    System.out.println(oddCount(1)); // 0
    System.out.println(oddCount(2)); // 1
    System.out.println(oddCount(7)); // 3
    System.out.println(oddCount(15)); // 7
    System.out.println(oddCount(16)); // 8
    System.out.println(oddCount(15023)); // 7511
  }
}

// java is doing the following implicitely
// return (int) Math.floor(n / 2);

// another method
// return n % 2 == 0 ? n / 2 : (n - 1) / 2;