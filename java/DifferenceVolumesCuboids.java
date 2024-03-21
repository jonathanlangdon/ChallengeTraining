// find the difference in volumes of 2 cuboids

import java.util.Arrays;

public class DifferenceVolumesCuboids {

  public static int findDifference(int[] firstCuboid, int[] secondCuboid) {
    int volume1 = Arrays.stream(firstCuboid).reduce(1, (acc, cur) -> acc * cur);
    int volume2 = Arrays.stream(secondCuboid).reduce(1, (acc, cur) -> acc * cur);
    return Math.abs(volume1 - volume2);
  }

  public static void main(String[] args) {
    System.out.println(findDifference(new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 })); // 14
  }
}