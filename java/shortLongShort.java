// output a string with short+long+short

public class shortLongShort {
  public static String solution(String a, String b) {
    String shortStr = a;
    String longStr = b;
    if (a.length() > b.length()) {
      shortStr = b;
      longStr = a;
    }
    return shortStr + longStr + shortStr;
  }

  public static void main(String[] args) {
    System.out.println(solution("11", "2")); // 2112
    System.out.println(solution("2", "11")); // 2112
  }
}