// with an input language output a greeting in a language

import java.util.HashMap;
import java.util.Map;
import java.util.Arrays;

public class WelcomeInLanguage {

  public static String greet(String language) {
    Map<String, String> greetingsMap = new HashMap<>();
    greetingsMap.put("english", "Welcome");
    greetingsMap.put("czech", "Vitejte");
    greetingsMap.put("danish", "Velkomst");
    greetingsMap.put("dutch", "Welkom");
    greetingsMap.put("estonian", "Tere tulemast");
    greetingsMap.put("finnish", "Tervetuloa");
    greetingsMap.put("flemish", "Welgekomen");
    greetingsMap.put("french", "Bienvenue");
    greetingsMap.put("german", "Willkommen");
    greetingsMap.put("irish", "Failte");
    greetingsMap.put("italian", "Benvenuto");
    greetingsMap.put("latvian", "Gaidits");
    greetingsMap.put("lithuanian", "Laukiamas");
    greetingsMap.put("polish", "Witamy");
    greetingsMap.put("spanish", "Bienvenido");
    greetingsMap.put("swedish", "Valkommen");
    greetingsMap.put("welsh", "Croeso");

    String[] invalidInput = new String[] { "IP_ADDRESS_INVALID", "IP_ADDRESS_NOT_FOUND", "IP_ADDRESS_REQUIRED", "" };

    if (language == null || Arrays.asList(invalidInput).contains(language))
      return "Welcome";
    return greetingsMap.get(language);
  }

  public static void main(String[] args) {
    System.out.println(greet("english")); // "Welcome"
    System.out.println(greet("dutch")); // "Welkom"
    System.out.println(greet("IP_ADDRESS_INVALID")); // "Welcome"
    System.out.println(greet("")); // "Welcome"
    System.out.println(greet(null)); // "Welcome"
  }
}