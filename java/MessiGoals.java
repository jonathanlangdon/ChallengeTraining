// output total goals in three leagues

public class MessiGoals {

  public static int goals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) {
    return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
  }

  public static void main(String[] args) {
    System.out.println(goals(0, 3, 0)); // 3
    System.out.println(goals(6, 3, 5)); // 14
  }
}