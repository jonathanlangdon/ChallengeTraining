public class PlayingBanjo {
  public static String areYouPlayingBanjo(String name) {
    String playsBanjo = " does not play banjo";
    if (name.toLowerCase().charAt(0) == 'r') {
      playsBanjo = " plays banjo";
    }
    return name + playsBanjo;
  }

  public static void main(String[] args) {
    System.out.println(areYouPlayingBanjo("Ricki"));
    System.out.println(areYouPlayingBanjo("ron"));
    System.out.println(areYouPlayingBanjo("Martin"));
  }
}