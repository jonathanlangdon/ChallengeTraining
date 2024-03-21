// return total salary with bonus based on arguments

public class DoIGetBonus {

  public static String bonusTime(int salary, boolean bonus) {
    return "£" + salary * (bonus ? 10 : 1);
  }

  public static void main(String[] args) {
    System.out.println(bonusTime(10000, true)); // £100000
    System.out.println(bonusTime(2, true)); // £20
    System.out.println(bonusTime(23, false)); // £23
  }
}