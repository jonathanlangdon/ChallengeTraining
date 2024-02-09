// converts a boolean to "Yes" or "No"

public class convertBooleanYesNo {
  public static String boolToWord(boolean b) {
    return b ? "Yes" : "No";
  }

  public static void main(String[] args) {
    System.out.println(boolToWord(true));
    System.out.println(boolToWord(false));
  }
}