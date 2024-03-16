// remove every other element in an array (2nd elements)

import java.util.Arrays;

public class RemovingOddElementsArray {

  public static Object[] removeEveryOther(Object[] arr) {
    Object[] reducedArr = new Object[(int) Math.ceil((double) arr.length / 2)];
    for (int i = 0; i < arr.length; i+= 2) {
      reducedArr[i / 2] = arr[i];
    }
    return reducedArr;
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(removeEveryOther(new Object[] { "Hello", "Goodbye", "Hello Again" }))); // ["Hello", "Hello Again"]
    System.out.println(Arrays.toString(removeEveryOther(new Object[] { "Hello", "Goodbye", "Hello Again", "Bye" }))); // ["Hello", "Hello Again"]
  }
}