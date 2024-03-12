// function to calculate volume of cuboid

public class VolumeCuboid {

  public static double getVolumeOfCuboid(double length, double width, double height) {
    return length * width * height;
  }

  public static void main(String[] args) {
    System.out.println(getVolumeOfCuboid(1, 2, 2)); // 4
    System.out.println(getVolumeOfCuboid(6.3, 2, 5)); // 63
  }

}

/*
 * Bob needs a fast way to calculate the volume of a cuboid with three values:
 * the length, width and height of the cuboid. Write a function to help Bob with
 * this calculation.
 */
