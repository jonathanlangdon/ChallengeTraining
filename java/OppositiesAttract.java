public class OppositiesAttract
{
    public static boolean isLove(final int flower1, final int flower2) {
        boolean hasOdd = false;
        boolean hasEven = false;
        if (flower1 % 2 == 0 || flower2 % 2 == 0) {
            hasEven = true;
        }        
        if (flower1 % 2 == 1 || flower2 % 2 == 1) {
            hasOdd = true;
        }
        return (hasEven && hasOdd);
    }

    public static void main(String[] args) {
        System.out.println(isLove(1, 4)); //true
        System.out.println(isLove(2, 5)); //true
        System.out.println(isLove(2, 4)); //false
    }
}