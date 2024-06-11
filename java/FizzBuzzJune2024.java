// Fizz Buzz with recursive function

public class FizzBuzzJune2024 {
  public static void fizzBuzz(int num) {
    if (num > 100)
      return;
    String result = "";
    if (num % 3 == 0)
      result += "Fizz";
    if (num % 5 == 0)
      result += "Buzz";
    if (result == "")
      result += num;
    System.out.println(result);
    fizzBuzz(num + 1);
  }

  public static void main(String[] args) {
    fizzBuzz(1);
  }
}