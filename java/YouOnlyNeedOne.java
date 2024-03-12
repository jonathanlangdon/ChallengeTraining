// return whether an array contains an item

import java.util.Arrays;

public class YouOnlyNeedOne {

  public static boolean check(Object[] a, Object x) {
    return Arrays.asList(a).contains(x);
  }

  public static void main(String[] args) {
    System.out.println(check(new Object[] { 66, 101 }, 66)); // true
    System.out.println(check(new Object[] { 34, 101 }, 66)); // false
  }
}

/*
 * You will be given an array a and a value x. All you need to do is check
 * whether the provided array contains the value.
 * 
 * Array can contain numbers or strings. X can be either.
 * 
 * Return true if the array contains the value, false if not.
 * 
 */
