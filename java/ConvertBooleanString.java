public class ConvertBooleanString {
  public static String convert(boolean b) {
    return Boolean.toString(b);
  }

  public static void main(String[] args) {
    System.out.println(convert(true));
  }
}
