// remove exclamation marks from a string

public class RemoveExclamation {

  static String removeExclamationMarks(String s) {
    return s.replace("!", "");
  }

  public static void main(String[] args) {
    System.out.println(removeExclamationMarks("Hello World!")); // Hello World
    System.out.println(removeExclamationMarks("Hello!! World!")); // Hello World
  }

}

/*
 * Write function RemoveExclamationMarks which removes all exclamation marks
 * from a given string.
 */