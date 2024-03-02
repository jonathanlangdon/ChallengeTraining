import java.util.Arrays;

public class NeedleInHaystack
{
    public static String findNeedle(Object[] haystack) {
        return "found the needle at position " + Arrays.asList(haystack).indexOf("needle");
    }
    public static void main(String[] args) {
		System.out.println(findNeedle(new Object[] {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"}));
	}
}