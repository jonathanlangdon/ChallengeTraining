// remove lowercase vowels

public class removeLowerCaseVowels{

  public static String shortcut(String input) {
    return input.replaceAll("[aeiou]", "");
  }

  public static void main(String[] args){
    System.out.println(shortcut("hello and HELLO")); // "hll nd HELLO"
  }
}