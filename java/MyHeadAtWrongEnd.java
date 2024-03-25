// re-arrange an array moving the last item to the first

import java.util.Arrays;
import java.util.ArrayList;
import java.util.Collections;

public class MyHeadAtWrongEnd {

  public static String[] fixTheMeerkat(String[] arr) {
    ArrayList<String> partsList = new ArrayList<>(Arrays.asList(arr));
    Collections.reverse(partsList);
    return partsList.toArray(new String[0]);
  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(fixTheMeerkat(new String[] { "bottom", "middle", "top" })));
    // ["top", "middle", "bottom"]
  }
}

/*
 * another method
 * 
 * String[] copy = arr.clone();
 * Collections.reverse(Arrays.asList(copy));
 * return copy;
 * 
 */