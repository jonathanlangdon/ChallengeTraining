// Convert strings to pig latin - part 1

import java.util.Arrays;
import java.util.stream.Stream;

public class PigLatin {
    public static String pigIt(String str) {
        String[] words = str.split(" ");
        String[] pigWords = new String[words.length];
        String[] punctuation = {"!", ".", "?", ",", ";", ":"};
        for (int i = 0; i < words.length; i++) {
          if (Arrays.asList(punctuation).contains(words[i][0])) {
            pigWords[i] = words[i];
          } else {
            pigWords[i] = "" //finish
          }
        }
        return String.join(" ", words);
    }

    public static void main(String[] args) {
      System.out.println(pigIt("Hello there boy !")); // elloHay heretay oybay !
    }
}
