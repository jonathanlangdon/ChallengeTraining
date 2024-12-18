// give all permutations of string characters removing duplicates... Update 2: setting up HashSet and for loops

import java.util.*;

public class StringPermutations {
    
  public static List<String> singlePermutations(String s) {
    Set<String> permSet = new HashSet<>();    
    String[] characters = s.split("");
    for (int i = 0; i < s.length; i++) {
      for (int j = 0; j < s.length; j++) {

      }
    }
    return new ArrayList<>(permSet);
  }


  public static void main(String[] args){
    System.out.println(singlePermutations("aabb"));
    // ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
    

  }

}