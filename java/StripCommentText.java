// strip extra characters out of a string according to passed in parameters - update 5

import java.util.Arrays;

public class StripCommentText {
    
  public static String stripComments(String text, String[] commentSymbols) {
    // System.out.println("testing test: " + text + "\ntesting symbols: " + Arrays.toString(commentSymbols));
    String[] outputLines = text.split("\n");
    for (String symbol : commentSymbols) {
      for (int i = 0; i < outputLines.length; i++) {
        if (outputLines[i].contains(symbol)) {
          int symbolIndex = outputLines[i].indexOf(symbol);
          if (symbolIndex == 0) {
            outputLines[i] = "";
          } else {
            outputLines[i] = outputLines[i].substring(0, symbolIndex).replaceAll("\\s+$", "");
          }
        } else {
          outputLines[i] = outputLines[i].replaceAll("\\s+$", "");
        }
      }
    }
    
		return String.join("\n", outputLines);
	}



  public static void main(String[] args){
    System.out.println(stripComments( "apples, pears # and bananas\ngrapes\nbananas !apples", new String[] { "#", "!" } ) + "\n***end***");
    // "apples, pears\ngrapes\nbananas"

    System.out.println(stripComments("a #b\nc\n\n\n\nd $e f g", new String[] { "#", "$" }) + "\n***end***");
    // "a\nc\nd"

    System.out.println(stripComments("#a #b\nc\nd## $e \nf \n$g#", new String[] { "#", "$" }) + "\n***end***");
    // "\nc\nd\nf\n"

    System.out.println(stripComments("a \nb \nc ", new String[] { "#", "$" }) + "\n***end***");
    // "a\nb\nc"

    System.out.println("empty string: '" + stripComments("a", new String[] {"a"}) + "'\n***end***");
    // ""

    System.out.println(stripComments("bbc\n\nd\n\na\n\n\n-e\n\nbe", new String[] { "-" }) + "\n***end***");
    // bbc\n\nd\n\na\n\n\n\n\nbe

    System.out.println(stripComments("a \n\n! \n\nf\n\ne ", new String[] { "!" }) + "\n***end***");
    // a\n\n\n\nf\n\ne 

    System.out.println(stripComments("c \n\ne-e\n\nefe", new String[] { "-" }) + "\n***end***");
    // c \n\ne\n\nefe
    

  }

}