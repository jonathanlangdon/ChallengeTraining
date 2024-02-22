public class KeepHydrated {

  public static int Liters(double time) {
    return (int) Math.floor(time * .5);
  }
  public static void main(String[] args) {
    System.out.println(Liters(6.7));
  }

}