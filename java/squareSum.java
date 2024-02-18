public class squareSum {
  public static int squaresSum(int[] array) {
    int sum = 0;
    for (int num : array) {
      sum += num * num;
    }
    return sum;
  }

  public static void main(String[] args) {

    System.out.println(squaresSum(new int[] { 1, 2, 2 })); // 9
    System.out.println(squaresSum(new int[] { 1, 2 })); // 5
    System.out.println(squaresSum(new int[] { 5, -3, 4 })); // 50
  }
}