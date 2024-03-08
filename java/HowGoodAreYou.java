// determine if your score is better than the class average

import java.util.Arrays;

public class HowGoodAreYou {
  public static boolean betterThanAverage(int[] classPoints, int yourPoints) {
    double classAverage = Arrays.stream(classPoints).average().orElse(0);
    return yourPoints > classAverage;
  }

  public static void main(String[] args) {
    System.out.println(betterThanAverage(new int[] { 2, 3 }, 5)); // true
    System.out.println(betterThanAverage(new int[] { 2, 3 }, 2)); // false

  }
}

/*
 * There was a test in your class and you passed it. Congratulations!
 * But you're an ambitious person. You want to know if you're better than the
 * average student in your class.
 * 
 * You receive an array with your peers' test scores. Now calculate the average
 * and compare your score!
 * 
 * Return True if you're better, else False!
 * Note:
 * 
 * Your points are not included in the array of your class's points. For
 * calculating the average point you may add your point to the given array!
 * 
 */