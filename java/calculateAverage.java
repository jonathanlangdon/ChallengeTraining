import java.util.Arrays;

public class calculateAverage {
  public static double find_average(int[] array) {
    int sum = Arrays.stream(array).reduce(0, (acc, cur) -> acc + cur);
    return array.length == 0 ? 0.0 : (double) sum / array.length;
  }

  public static void main(String[] args) {
    System.out.println(find_average(new int[] { 1, 2, 3 }));
    System.out.println(find_average(new int[] {}));

  }
}