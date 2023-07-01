// get character from ASCII Value

public class GetCharacter {
    public static void main(String[] args) {
        Kata kata = new Kata();
        kata.printReturn();
    }
    
    static class Kata {
        public static char getChar(int c) {
            return (char) c;
        }
        
        public void printReturn() {
            System.out.println(getChar(100));
        }
    }
}

/*Write a function get_char() / getChar() which takes a number and returns the corresponding ASCII char for that value.

Example:

get_char(65)

should return:

'A'
*/
