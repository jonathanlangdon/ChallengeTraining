// convert DNA to RNA

public class DNAtoRNA {

  public static String dnaToRna(String dnaString) {
    return dnaString.replaceAll("T", "U");
  }

  public static void main(String[] args) {
    System.out.println(dnaToRna("GCAT")); // "GCAU"
    System.out.println(dnaToRna("TTTT")); // "UUUU"
  }
}

/*
 * Create a function which translates a given DNA string into RNA.
 * 
 * For example:
 * 
 * "GCAT" => "GCAU"
 * 
 * The input string can be of arbitrary length - in particular, it may be empty.
 * All input is guaranteed to be valid, i.e. each input string will only ever
 * consist of 'G', 'C', 'A' and/or 'T'.
 */
