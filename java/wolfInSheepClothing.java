// spot wolf in sheep's clothing and give warning

import java.util.Arrays;

public class wolfInSheepClothing {
  public static String warnTheSheep(String[] arr) {
    int wolfIndex = Arrays.asList(arr).indexOf("wolf");
    // System.out.println("wolf index is " + wolfIndex);
    if (wolfIndex == arr.length - 1) {
      return "Pls go away and stop eating my sheep";
    }
    return String.format("Oi! Sheep number %d! You are about to be eaten by a wolf!", arr.length - wolfIndex - 1);
  }

  public static void main(String[] args) {
    System.out.println(warnTheSheep(new String[] {"sheep", "wolf", "sheep"}));
    // "Oi! Sheep number 1! You are about to be eaten by a wolf!"
    System.out.println(warnTheSheep(new String[] {"sheep", "wolf", "sheep", "sheep"}));
    // "Oi! Sheep number 2! You are about to be eaten by a wolf!"
    System.out.println(warnTheSheep(new String[] {"sheep", "sheep", "wolf"}));
    // "Pls go away and stop eating my sheep"
    System.out.println(warnTheSheep(new String[]{"sheep", "wolf", "sheep", "sheep", "sheep", "sheep", "sheep"}));
    // "Oi! Sheep number 5! You are about to be eaten by a wolf!"

  }
}