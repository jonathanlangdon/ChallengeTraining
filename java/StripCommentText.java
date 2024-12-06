// strip extra characters out of a string according to passed in parameters

import java.util.Arrays;

public class StripCommentText {
    
  public static String stripComments(String text, String[] commentSymbols) {
    // System.out.println("testing test: " + text + "\ntesting symbols: " + Arrays.toString(commentSymbols));
    String newText = String.join("\n", Arrays.stream(text.split("\n")).map(String::stripTrailing).toArray(String[]::new));
    for (String symbol : commentSymbols) {
      boolean textHasSymbol = newText.contains(symbol);
      while (textHasSymbol) {
        newText = removeOneComment(newText, symbol);
        textHasSymbol = newText.contains(symbol);
      }   
    }
    
		return newText;
	}

  public static String removeOneComment(String text, String symbol) {
      int symbolIndex = text.indexOf(symbol);
      String commentString = text.substring(symbolIndex);

      if (!commentString.contains("\n")) {
        if (symbolIndex == 0) return "";
        return text.substring(0, symbolIndex - 1).trim();
      } else {
        int nextEndLineIndex = text.indexOf("\n", symbolIndex);
        return text.substring(0, symbolIndex).trim() + text.substring(nextEndLineIndex);
      }
  }

  public static void main(String[] args){
    System.out.println(stripComments( "apples, pears # and bananas\ngrapes\nbananas !apples", new String[] { "#", "!" } ) + "\n");
    // "apples, pears\ngrapes\nbananas"
    System.out.println(stripComments("a #b\nc\n\n\n\nd $e f g", new String[] { "#", "$" }) + "\n");
    // "a\nc\nd"

    System.out.println(stripComments("#a #b\nc\nd## $e \nf \n$g#", new String[] { "#", "$" }) + "\n");
    // "c\nd\nf"

    System.out.println(stripComments("a \nb \nc ", new String[] { "#", "$" }) + "\n");
    // "a\nb\nc"

    System.out.println("empty string: '" + stripComments("a", new String[] {"a"}) + "'\n");
    // ""

    

  }

}
