// fix misinterpreted characters from character recognition software

public class CharacterRecognitionMistakes {

  public static String correct(String str) {
    return str.replace("5", "S").replace("0", "O").replace("1", "I");
  }

  public static void main(String[] args) {
    System.out.println(correct("R0BERT MERLE - THE DAY 0F THE D0LPH1N5")); // "ROBERT MERLE - THE DAY OF THE DOLPHINS"
  }
}

/*
 * method using for loop:
 * 
 * String newStr = "";
 * for (char c : str.toCharArray()) {
 * if (c == '5') newStr += 'S';
 * else if (c == '0') newStr += 'O';
 * else if (c == '1') newStr += 'I';
 * else newStr += c;
 * }
 * return newStr;
 */