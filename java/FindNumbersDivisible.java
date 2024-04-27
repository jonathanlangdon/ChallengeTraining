// for a given value, find which items in an array are divisble by that value

import java.util.stream.*;
import java.util.Arrays;

public class FindNumbersDivisible {
  public static int[] divisibleBy(int[] numbers, int divider) {
    return Arrays.stream(numbers)
                  .filter(i -> (i % divider) == 0)
                  .toArray();
  }

  public static void main(String[] args)
  {
    System.out.println(Arrays.toString(divisibleBy(new int[] {1, 2, 3, 4}, 2))); //[2, 4]
  }
}

/* other method:
    List<Integer> divisibleList = new ArrayList<>();
    for (int num : numbers) {
      if (num % divider == 0) divisibleList.add(num);
    }
    int[] result = new int[divisibleList.size()];
    for (int i = 0; i < divisibleList.size(); i++) {
      result[i] = divisibleList.get(i);
    }
    return result;
*/