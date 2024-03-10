// return whether an alaram needs to be set based on 1) employment 2) vacation

public class SetAlarm {

  public static boolean setAlarm(boolean employed, boolean vacation) {
    return employed && !vacation;
  }

  public static void main(String[] args) {
    System.out.println(setAlarm(true, false)); // true
    System.out.println(setAlarm(false, false)); // false
    System.out.println(setAlarm(false, true)); // false
    System.out.println(setAlarm(true, true)); // false
  }
}