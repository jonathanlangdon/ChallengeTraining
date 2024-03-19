// convert human years to cat and dog years

import java.util.Arrays;

public class DogYearsCatYears {

  public static int[] humanYearsCatYearsDogYears(final int humanYears) {
    int catYears = 15 + (humanYears > 2 ? 9 + (humanYears - 2) * 4 : humanYears == 2 ? 9 : 0);
    int dogYears = 15 + (humanYears > 2 ? 9 + (humanYears - 2) * 5 : humanYears == 2 ? 9 : 0);
    return new int[] { humanYears, catYears, dogYears };
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(humanYearsCatYearsDogYears(1))); // [1, 15, 15]
    System.out.println(Arrays.toString(humanYearsCatYearsDogYears(2))); // [2, 24, 24]
    System.out.println(Arrays.toString(humanYearsCatYearsDogYears(3))); // [3, 28, 29]
  }
}