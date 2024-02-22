public class MapArrayMethod {
  public static int[] map(int[] arr) {
    int[] newArr = new int[arr.length];
    for (int i = 0; i < arr.length; i++) {
      newArr[i] = arr[i] * 2;
    }
    return newArr;
  }

  public static void main(String[] args) {
    System.out.println(map(new int[] { 1, 2, 3 })); //
  }
}