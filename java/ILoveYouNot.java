// return what phrase a girl would say when picking petals off a flower

public class ILoveYouNot {

  public static String howMuchILoveYou(int petals) {
    int petalCount = petals % 6;
    switch(petalCount) {
      case(0): return "not at all";
      case(1): return "I love you";
      case(2): return "a little";
      case(3): return "a lot";
      case(4): return "passionately";
      case(5): return "madly";
      default: return "Invalid input";
    }
  }

  public static void main(String[] args) {
    System.out.println(howMuchILoveYou(1)); // I love you
    System.out.println(howMuchILoveYou(2)); // a little
    System.out.println(howMuchILoveYou(6)); // "not at all"
    System.out.println(howMuchILoveYou(7)); // "I love you"
    System.out.println(howMuchILoveYou(8)); // "a little"
  }
}