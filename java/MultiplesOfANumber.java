// return multiples of a value up to a integer input

import java.util.Arrays;

public class MultiplesOfANumber{

  public static int[] find(int base, int limit) {
    int[] multiplesArr = new int[limit / base];
    for (int i = 0; i < multiplesArr.length; i++){
      multiplesArr[i] = (i + 1) * base;
    }
    return multiplesArr;
  }

  public static void main(String[] args){
    System.out.println(Arrays.toString(find(5, 25))); // 5, 10, 15, 20 25
    System.out.println(Arrays.toString(find(5, 24))); // 5, 10, 15, 20
  }
}