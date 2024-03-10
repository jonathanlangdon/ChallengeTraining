// turn an array into a sentence

import java.util.Arrays;

public class SentenceSmash {
  public static String smash(String... words) {
    return Arrays.stream(words).reduce("", (acc, cur) -> acc + cur + " ").trim();
  }

  public static void main(String[] args) {
    System.out.println(smash(new String[] { "hello", "world", "this", "is", "great" })); // returns "hello world this is
                                                                                         // great"
  }
}

/*
 * Write a function that takes an array of words and smashes them together into
 * a sentence and returns the sentence. You can ignore any need to sanitize
 * words or add punctuation, but you should add spaces between each word. Be
 * careful, there shouldn't be a space at the beginning or the end of the
 * sentence!
 */

// better method: return String.join(" ", words);