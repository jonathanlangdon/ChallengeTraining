// FizzBuzz May 2024

public class fizzBuzzMay2024 {
  public static void fizzbuzz() {
    for (int i = 1; i <= 100; i++) {
      boolean fizz = i % 3 == 0;
      boolean buzz = i % 5 == 0;
      String result = "";
      if (fizz && buzz) {
        result = "FizzBuzz";
      } else if (fizz) {
        result = "Fizz";
      } else if (buzz) {
        result = "Buzz";
      } else {
        result = String.valueOf(i);
      }
      System.out.println(result);
    }
    System.out.println("\n");
  }

  public static void main(String[] args) {
    fizzbuzz();
  }
}