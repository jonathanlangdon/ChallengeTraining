// give all permutations of string characters removing duplicates... Update 1: Test Case setup 

import java.util.*;

public class StringPermutations {
    
    public static List<String> singlePermutations(String s) {

        return new ArrayList<>(Arrays.asList(s.split("")));
    }


  public static void main(String[] args){
    System.out.println(singlePermutations("aabb"));
    // ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
    

  }

}
