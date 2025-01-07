// draw stairs based on input # steps

public class DrawStairs {

  public static String draw(int n){
    StringBuilder stairs = new StringBuilder("");
    for (int i = 0; i < n; i++) {
      stairs.append("I");
      if (i != n - 1) {
        stairs.append("\n");
        stairs.append(" ".repeat(i + 1));
      }
    }
    return stairs.toString();
  }

  public static void main(String[] args) {
    System.out.println(draw(3)); // "I\n I\n  I"
  }
}
