// Stringy Strings

public class StringyStrings {
    public static void main(String[] args) {
        Kata kata = new Kata();
        kata.printReturn();
    }
    
    static class Kata {
        public static String stringy(int size) {
            String str = "";
            for (int i = 1; i <= size; i++) {
              str += (i % 2) + "";
            }
            return str;
        }
        
        public void printReturn() {
            System.out.println(stringy(1));
        }
    }
}

/* write me a function stringy that takes a size and returns a string of alternating '1s' and '0s'.

the string should start with a 1.

a string with size 6 should return :'101010'.

with size 4 should return : '1010'.

with size 12 should return : '101010101010'.

The size will always be positive and will only use whole numbers.
*/
