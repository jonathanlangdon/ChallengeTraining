// return area for squares and perimeters for rectangles

public class AreaPerimeter {

  public static int areaOrPerimeter(int l, int w) {
    return l == w ? l * w : 2 * l + 2 * w;
  }

  public static void main(String[] args) {
    System.out.println(areaOrPerimeter(4, 4)); // 16
    System.out.println(areaOrPerimeter(6, 10)); // 32
  }
}

/*
 * You are given the length and width of a 4-sided polygon. The polygon can
 * either be a rectangle or a square.
 * If it is a square, return its area. If it is a rectangle, return its
 * perimeter.
 */