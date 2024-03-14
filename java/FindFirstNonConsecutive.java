// return the first value from an array that is not consecutive

public class FindFirstNonConsecutive {

  public static Integer find(final int[] array) {
    for (int i = 1; i < array.length; i++) {
      if (array[i] - 1 != array[i - 1]) {
        return array[i];
      }
    }
    return null;
  }

  public static void main(String[] args) {
    System.out.println(find(new int[] { 1, 2, 4, 5, 6 })); // 4
    System.out.println(find(new int[] { 1, 2, 3, 4, 5 })); // null
  }
}