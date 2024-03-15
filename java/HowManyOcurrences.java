// returns how many occurances of a character are in a string

public class HowManyOcurrences {

  public static int strCount(String str, char letter) {
    int count = 0;
    for (char item : str.toCharArray()) {
      if (item == letter) {
        count += 1;
      }
    }
    return count;
  }

  public static void main(String[] args) {
    System.out.println(strCount("Hello", 'o')); // 1
    System.out.println(strCount("Hello", 'l')); // 2
    System.out.println(strCount("Hello", 'z')); // 0
    System.out.println(strCount("", 'z')); // 0
  }
}