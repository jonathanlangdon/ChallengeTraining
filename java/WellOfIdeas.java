// Well of ideas - Easy Version

import java.util.Arrays;

public class WellOfIdeas {
    static class Kata {
      public static String well(String[] x) {
        long ideas = Arrays.stream(x)
          .filter(idea -> idea.equals("good"))
          .count();
        return ideas == 0 ? "Fail!" : ideas > 2 ? "I smell a series!" : "Publish!";
      }
    }
  public static void main(String[] args) {
    System.out.println(Kata.well(new String[] {"good", "good", "good", "bad"}));
  }
}

/* For every good kata idea there seem to be quite a few bad ones!

In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'. If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'. If there are no good ideas, as is often the case, return 'Fail!'.
 */
