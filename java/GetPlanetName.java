// fix the switch statement of planet numbers

public class GetPlanetName {

  static String getPlanetName(int id) {
    return switch (id) {
      case 1 -> "Mercury";
      case 2 -> "Venus";
      case 3 -> "Earth";
      case 4 -> "Mars";
      case 5 -> "Jupiter";
      case 6 -> "Saturn";
      case 7 -> "Uranus";
      case 8 -> "Neptune";
      default -> throw new IllegalArgumentException(id + " is not a planet id");
    };
  }

  public static void main(String[] args) {
    System.out.println(getPlanetName(3)); // Earth
  }
}

/*
 * The function is not returning the correct values. Can you figure out why?
 * 
 * Example (Input --> Output ):
 * 
 * 3 --> "Earth"
 * 
 * 
 */
