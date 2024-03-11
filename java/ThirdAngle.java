// return 3rd angle of a triangle

public class ThirdAngle {

  public static int otherAngle(int angle1, int angle2) {
    return 180 - angle1 - angle2;
  }

  public static void main(String[] args) {
    System.out.println(otherAngle(45, 12)); // 123
    System.out.println(otherAngle(50, 60)); // 70
  }
}

/*
 * You are given two interior angles (in degrees) of a triangle.
 * 
 * Write a function to return the 3rd.
 * 
 * Note: only positive integers will be tested.
 */