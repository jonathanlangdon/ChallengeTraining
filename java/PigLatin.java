// Convert strings to pig latin - finished

import java.util.Arrays;
import java.util.stream.Stream;

public class PigLatin {
    public static String pigIt(String str) {
        String[] words = str.split(" ");
        String[] pigWords = new String[words.length];
        Character[] punctuation = {'!', '.', '?', ',', ';', ':'};
        for (int i = 0; i < words.length; i++) {
          if (Arrays.asList(punctuation).contains(words[i].charAt(0))) {
            pigWords[i] = words[i];
          } else {
            pigWords[i] = words[i].substring(1) + words[i].charAt(0) + "ay";
          }
        }
        return String.join(" ", pigWords);
    }

    public static void main(String[] args) {
      System.out.println(pigIt("Hello there boy !")); // elloHay heretay oybay !
    }
}
