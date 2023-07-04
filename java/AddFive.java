// Grasshopper - Basic Function Fixer - updated

public class AddFive {
  public static void main(String[] args) {
      Kata kata = new Kata();
      kata.printReturn();
  }
  
  static class Kata {
      public static int addFive(int num) {
          return num + 5;
      }
 //simplified and condensed 

      public void printReturn() {
          System.out.println(addFive(10));
      }
  }
}

/* Fix the function

I created this function to add five to any number that was passed in to it and return the new value. It doesn't throw any errors but it returns the wrong number.

Can you help me fix the function?
*/
