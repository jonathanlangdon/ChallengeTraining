// turn a numbered list into a range of integers

import java.util.Arrays;

public class IntervalsFromNumbers {
    
  public static String rangeExtraction(int[] arr) {

    if (arr.length < 3) return Arrays.toString(arr).replaceAll("[\\[\\] ]", "");

    StringBuilder ranges = new StringBuilder();
    int firstEndPoint = arr[0];
    boolean rangeInProgress = false;
    boolean recentlyFinishedRange = false;


    for (int i = 2; i < arr.length; i++) {

      int twoAgoPrevious = arr[i - 2];
      int previousNum = arr[i - 1];
      int currentNum = arr[i];



      // at end of array - append final numbers
      if (i == arr.length - 1) {
        if (previousNum + 1 == currentNum && previousNum == twoAgoPrevious + 1) {
          rangeInProgress = true;
        }
        if (rangeInProgress && previousNum + 1 == currentNum) {
          ranges.append(firstEndPoint).append("-").append(currentNum); // last numbers were a range
        } else if (rangeInProgress && previousNum + 1 != currentNum) {
          ranges.append(firstEndPoint).append("-").append(previousNum).append(",").append(currentNum);
        } else if (twoAgoPrevious == arr[0] || !recentlyFinishedRange) {
          ranges.append(twoAgoPrevious).append(",").append(previousNum).append(",").append(currentNum);
        } else ranges.append(previousNum).append(",").append(currentNum);
      }

      else if (previousNum + 1 == currentNum && previousNum == twoAgoPrevious + 1) {
          rangeInProgress = true;
          recentlyFinishedRange = false;
      }

      else if (recentlyFinishedRange) {
        recentlyFinishedRange = false;
        firstEndPoint = previousNum;
        continue;
      }

      
      // previous num not in a range with current num
      else {
        if (rangeInProgress) {
          ranges.append(firstEndPoint).append("-").append(previousNum);
          recentlyFinishedRange = true;
        }
        // beginning of arr situation
        else {
          ranges.append(twoAgoPrevious); // not a range
          recentlyFinishedRange = false;
        }
        ranges.append(",");
        firstEndPoint = previousNum;
        rangeInProgress = false;
      }
    }
    return ranges.toString();
  }

  public static void main(String[] args){
    System.out.println(rangeExtraction(new int[] {-6,-3,-2,-1,0,1,3,4,5,7,8,9,10,11,14,15,17,18,19,20})); // "-6,-3-1,3-5,7-11,14,15,17-20"));
    System.out.println(rangeExtraction(new int[] {-3,-2,-1,2,10,15,16,18,19,20})); // "-3--1,2,10,15,16,18-20"));
    System.out.println(rangeExtraction(new int[] {2, 3, 4, 5, 7})); // "2-5, 7"));
    System.out.println(rangeExtraction(new int[] {2, 3, 4, 5, 6, 7})); // "2-7"));
    System.out.println(rangeExtraction(new int[] {2, 5, 6, 7})); // "2, 5-7"));
    System.out.println(rangeExtraction(new int[] {2, 5, 7})); // "2,5,7"));
    System.out.println(rangeExtraction(new int[] {2, 3})); // "2,3"));
    System.out.println(rangeExtraction(new int[] {2, 3, 4})); // "2-4"));
    System.out.println(rangeExtraction(new int[] {1, 3, 4})); // "1, 3, 4"));
    System.out.println(rangeExtraction(new int[] {0, 2, 3, 4})); // "0, 2-4"));
    System.out.println(rangeExtraction(new int[] {1, 2, 4})); // "1, 2, 4"));
    System.out.println(rangeExtraction(new int[] {})); // ""));
    System.out.println(rangeExtraction(new int[] {3})); // "3"));
    System.out.println(rangeExtraction(new int[] {-9, -6, -5, -3, -2, -1, 2, 3, 5, 6})); // -9, -6, -5, -3--1, 2, 3, 5, 6
  }

}