// return sum of values of a mixed Array of Strings & numbers

import java.util.List;
import java.util.Arrays;

public class SumMixedArray {

  public static int sum(List<?> mixed) {
    int sum = 0;
    for (Object element : mixed) {
      sum += Integer.parseInt("" + element);
    }
    return sum;
  }

  public static void main(String[] args) {
    System.out.println(sum(Arrays.asList("3", 6, 6, 0, "5", 8, 5, "6", 2, "0"))); // 41
  }
}