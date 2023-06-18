public class ConvertNumber {
    public static void main(String[] args) {
        class Kata {
            private String numberToString(int num) {
                return Integer.toString(num);
            }
            
            public void printNumberAsString() {
                System.out.println(numberToString(4));
            }
        }
        
        Kata kata = new Kata();
        kata.printNumberAsString();
    }
}

/* We need a function that can transform a number (integer) into a string.

What ways of achieving this do you know?
Examples (input --> output):

123  --> "123"
999  --> "999"
-100 --> "-100"

 */