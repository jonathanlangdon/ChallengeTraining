public class CountTheSheep {
  public static String noSpace(final String x) {
    return x.replaceAll("\\s", "");
  }

  public static void main(String[] args) {
    System.out.println(noSpace(" . d    dgh .   ")); // ".ddgh."
  }
}