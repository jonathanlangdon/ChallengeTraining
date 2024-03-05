// convert a string into array of words

import java.util.Arrays;

public class ConvertStringToArray {

  public static String[] stringToArray(String s) {
    return s.split(" ");
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(stringToArray("I love arrays they are my favorite"))); //
  }
}

/*
 * Write a function to split a string and convert it into an array of words.
 */
