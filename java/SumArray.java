public class SumArray {
  public static double sum(double[] numbers) {
    double numSum = 0;
    for (double num : numbers) {
      numSum += num;
    }
    return numSum;
  }

  public static void main(String[] args) {
    System.out.println(sum(new double[] { 1.3, 1 })); // 2.3
  }
}

// good alternative using .sum() method

/*
 * 
 * import java.util.Arrays;
 * 
 * public class SumArray {
 * 
 * public static double sum(double[] numbers) {
 * return Arrays.stream(numbers).sum();
 * }
 * }
 * 
 */