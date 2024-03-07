// count sheep based on inputed number

public class CountSheep {

  public static String countingSheep(int num) {
    StringBuilder sheepStr = new StringBuilder();
    for (int i = 0; i < num; i++) {
      sheepStr.append((i + 1) + " sheep...");
    }
    return sheepStr.toString();
  }

  public static void main(String[] args) {
    System.out.println(countingSheep(3)); //
  }
}

/*
 * Given a non-negative integer, 3 for example, return a string with a murmur:
 * "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no
 * negative integers.
 */
