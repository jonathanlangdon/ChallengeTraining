// returns sum of only positive integers

public class sumOfPositive {
  public static int sum(int[] arr) {
    int total = 0;
    for (int num : arr) {
      if (num > 0) {
        total += num;
      }
    }
    return total;
  }

  public static void main(String[] args) {
    System.out.println(sum(new int[] { 1, 2, 3, 4, 5 })); // 15
    System.out.println(sum(new int[] { 1, -2, 3, 4, 5 })); // 13
    System.out.println(sum(new int[] {})); // 0
    System.out.println(sum(new int[] { -1, -2, -3, -4, -5 })); // 0
  }
}
