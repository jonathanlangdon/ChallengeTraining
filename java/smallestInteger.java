public class smallestInteger {
  public static int findSmallestInt(int[] array) {
    int smallest = array[0];
    for (int num : array) {
      if (num < smallest) {
        smallest = num;
      }
    }
    return smallest;
  }

  public static void main(String[] args) {

    System.out.println(findSmallestInt(new int[] { 34, 15, 88, 2 })); // 2
  }
}