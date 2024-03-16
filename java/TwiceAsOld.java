// calculate how many years from(or to) when a father is twice as old as his son

public class TwiceAsOld {

  public static int TwiceAsOld(int dadYears, int sonYears) {
    return Math.abs(dadYears - sonYears * 2);
  }

  public static void main(String[] args) {
    System.out.println(TwiceAsOld(39, 7)); // 25
    System.out.println(TwiceAsOld(39, 21)); // 3
  }
}