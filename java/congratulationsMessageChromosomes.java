// return message son/daughter based on chromosomes

public class congratulationsMessageChromosomes {
  public static String chromosomeCheck(String sperm) {
    String gender = sperm == "XX" ? "daughter" : "son";
    return String.format("Congratulations! You're going to have a %s.", gender);
  }

  public static void main(String[] args) {
    System.out.println(chromosomeCheck("XX")); // Congratulations!... daughter
    System.out.println(chromosomeCheck("XY")); // Congratulations!... son
  }
}