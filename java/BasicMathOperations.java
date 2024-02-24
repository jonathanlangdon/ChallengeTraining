public class BasicMathOperations {
  public static Integer basicMath(String op, int v1, int v2) {
    switch (op) {
      case "+":
        return v1 + v2;
      case "-":
        return v1 - v2;
      case "*":
        return v1 * v2;
      case "/":
        return v1 / v2;
      default:
        return 0;
    }
  }

  public static void main(String[] args) {
    System.out.println(basicMath("+", 4, 7)); // 11
    System.out.println(basicMath("/", 50, 5)); // 10

  }
}
