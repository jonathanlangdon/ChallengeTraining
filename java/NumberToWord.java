// rewrite a single digit integer into a string word

import java.util.Map;
import java.util.HashMap;

public class NumberToWord {

  public static String switchItUp(int number) {
    Map<Integer, String> digitMap = new HashMap<>();
    digitMap.put(0, "Zero");
    digitMap.put(1, "One");
    digitMap.put(2, "Two");
    digitMap.put(3, "Three");
    digitMap.put(4, "Four");
    digitMap.put(5, "Five");
    digitMap.put(6, "Six");
    digitMap.put(7, "Seven");
    digitMap.put(8, "Eight");
    digitMap.put(9, "Nine");

    return digitMap.get(number);
  }

  public static void main(String[] args) {
    System.out.println(switchItUp(3)); // "Three"
  }
}

/*
 * When provided with a number between 0-9, return it in words.
 * 
 * Input :: 1
 * 
 * Output :: "One".
 */