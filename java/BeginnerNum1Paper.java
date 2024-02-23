public class BeginnerNum1Paper {
  public static int paperWork(int n, int m) {
    if (n < 0 || m < 0)
      return 0;
    return n * m;
  }

  public static void main(String[] args) {
    System.out.println(paperWork(5, 5)); // 25
    System.out.println(paperWork(-5, 5)); // 0
  }
}