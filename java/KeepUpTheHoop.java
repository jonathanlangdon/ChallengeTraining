// return an encouragement based on input value

public class KeepUpTheHoop {

  public static String hoopCount(int n) {
    return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
  }

  public static void main(String[] args) {
    System.out.println(hoopCount(9)); // "Keep at it until you get it"
    System.out.println(hoopCount(10)); // "Great, now move on to tricks"
    System.out.println(hoopCount(11)); // "Great, now move on to tricks"
  }
}