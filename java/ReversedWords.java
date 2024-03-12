// reverse words in a string

import java.util.Collections;
import java.util.Arrays;
import java.util.List;

public class ReversedWords {

  public static String reverseWords(String str) {
    List<String> wordList = Arrays.asList(str.split(" "));
    Collections.reverse(wordList);
    return String.join(" ", wordList);
  }

  public static void main(String[] args) {
    System.out.println(reverseWords("yoda doesn't speak like this")); // this like speak doesn't yoda
  }
}