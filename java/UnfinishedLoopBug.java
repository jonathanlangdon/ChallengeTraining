// fix bug in a loop

import java.util.*;

public class UnfinishedLoopBug {

  public static List<Integer> CreateList(int number) {
    List<Integer> newList = new ArrayList<>();
    for (int i = 1; i <= number; i++) {
      newList.add(i);
    }
    return newList;
  }

  public static void main(String[] args) {
    System.out.println(CreateList(3)); // [1, 2, 3]
  }
}