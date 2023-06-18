public class ReversedStrings {
    public static void main(String[] args) {
        Kata kata = new Kata();
        kata.printReturn();
    }
    
    static class Kata {
        public static String solution(String str) {
            StringBuilder reverse = new StringBuilder(str).reverse();
            return reverse.toString();
        }
        
        public void printReturn() {
            System.out.println(solution("world"));
        }
    }
}



/*Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow'


 */