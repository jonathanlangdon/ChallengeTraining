// based on if name is boss's name... return "hello boss" or "hello guest"

public class PersonalizedBossGreeting {

  static String greet(String name, String owner) {
    return "Hello " + (name.equals(owner) ? "boss" : "guest");
  }

  public static void main(String[] args) {
    System.out.println(greet("Daniel", "Daniel")); // "Hello boss"
    System.out.println(greet("Greg", "Daniel")); // "Hello guest"
  }
}

/*
 * Create a function that gives a personalized greeting. This function takes two
 * parameters: name and owner.
 */
