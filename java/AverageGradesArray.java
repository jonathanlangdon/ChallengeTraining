// average grades iun an array

import java.util.Arrays;

public class AverageGradesArray {

  public static int getAverage(int[] marks) {
    return (int) Arrays.stream(marks).average().orElse(0);
  }

  public static void main(String[] args) {
    System.out.println(getAverage(new int[] { 2, 3, 3, 3 })); // 2
    System.out.println(getAverage(new int[] { 2, 2, 2, 3 })); // 2
    System.out.println(getAverage(new int[] { 1, 2, 3, 4, 5 })); // 3
  }
}

/*
 * It's the academic year's end, fateful moment of your school report. The
 * averages must be calculated. All the students come to you and entreat you to
 * calculate their average for them. Easy ! You just need to write a script.
 * 
 * Return the average of the given array rounded down to its nearest integer.
 * 
 * The array will never be empty.
 */