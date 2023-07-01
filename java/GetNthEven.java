// Get Nth Even Number

public class GetNthEven {
    public static void main(String[] args) {
        Kata kata = new Kata();
        kata.printReturn();
    }
    
    static class Kata {
        public static int nthEven(int n) {
            return n * 2 - 2;
        }
        
        public void printReturn() {
            System.out.println(nthEven(3));
        }
    }
}
/*
Return the Nth Even Number

Example(Input --> Output)

1 --> 0 (the first even number is 0)
3 --> 4 (the 3rd even number is 4 (0, 2, 4))
100 --> 198
1298734 --> 2597466

The input will not be 0.
*/
