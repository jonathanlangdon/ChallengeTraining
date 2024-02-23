public class ReverseArrayDigits {
  public static int[] digitize(long n) {
    String numString = n + "";
    ArrayList<int> intArrayList = new ArrayList<>();
    for (char ch : numString.toCharArray()) {
      intArrayList.add(0,(int) ch);
    }
    return intArrayList.stream().mapToInt(Integer::intValue).toArray();  }

  public static void main(String[] args) {
    System.out.println(Arrays.toString(digitize(35231)));
  }
}
