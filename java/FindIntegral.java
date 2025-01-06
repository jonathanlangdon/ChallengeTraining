// find integral given exponent and coefficient

public class FindIntegral {
    
    public static String integrate(int coefficient, int exponent) {
        int newExponent = exponent + 1;
        int newCoefficient = coefficient / newExponent;
        return newCoefficient + "x^" + newExponent;
    }


  public static void main(String[] args){
    System.out.println(integrate(3, 2)); // 1x^3
    System.out.println(integrate(12, 5)); // 2x^6
    System.out.println(integrate(20, 1)); // 10x^2
    System.out.println(integrate(40, 3)); // 10x^4
  }
}
