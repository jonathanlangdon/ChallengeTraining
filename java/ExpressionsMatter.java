// return the maximum number from a possible mathematical combinations

import java.util.Arrays;

public class ExpressionsMatter {

  public static int expressionsMatter(int a, int b, int c) {
    int ans1 = a * b * c;
    int ans2 = a + b + c;
    int ans3 = (a + b) * c;
    int ans4 = a * (b + c);
    int[] ansArr = new int[] { ans1, ans2, ans3, ans4 };
    return Arrays.stream(ansArr).max().orElse(0);
  }

  public static void main(String[] args) {
    System.out.println(expressionsMatter(1, 2, 3)); // 9
    System.out.println(expressionsMatter(1, 3, 1)); // 5
    System.out.println(expressionsMatter(2, 1, 2)); // 6
    System.out.println(expressionsMatter(2, 1, 1)); // 4
    System.out.println(expressionsMatter(1, 1, 2)); // 4
    System.out.println(expressionsMatter(1, 1, 1)); // 3
    System.out.println(expressionsMatter(1, 3, 1)); // 5
    System.out.println(expressionsMatter(5, 1, 3)); // 20
    System.out.println(expressionsMatter(6, 7, 1)); // 48
    System.out.println(expressionsMatter(1, 8, 3)); // 27
    System.out.println(expressionsMatter(9, 1, 1)); // 18
  }
}