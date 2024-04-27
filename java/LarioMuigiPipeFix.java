// fix a sequence of numbers so values increment by 1 between each

import java.util.Arrays;
import java.util.stream.IntStream;

public class LarioMuigiPipeFix {
  public static int[] pipeFix(int[] numbers) {
    return IntStream.rangeClosed(numbers[0], numbers[numbers.length - 1]).toArray();
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(pipeFix(new int[] { 1, 3, 5 }))); // 1, 2, 3, 4, 5
    System.out.println(Arrays.toString(pipeFix(new int[] { 6, 7, 10 }))); // 6, 7, 8, 9, 10
  }
}