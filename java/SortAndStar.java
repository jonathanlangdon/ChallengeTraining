// take an array, sort it, and return first value with extra *** added

public class SortAndStar {

  public static String twoSort(String[] s) {
    java.util.Arrays.sort(s);
    return String.join("***", s[0].split(""));
  }

  public static void main(String[] args) {
    System.out.println(
        twoSort(new String[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
    // "b***i***t***c***o***i***n"
  }
}

/*
 * my first way trying:
 * 
 * String[] sortedArr = Arrays.copyOf(s, s.length);
 * Arrays.sort(sortedArr);
 * char[] charArr = sortedArr[0].toCharArray();
 * String stringOut = "";
 * for (char c : charArr) {
 * stringOut += c + "***";
 * }
 * return stringOut.substring(0, stringOut.length() - 3);
 * 
 */