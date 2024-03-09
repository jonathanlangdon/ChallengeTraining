// calculate total championship points for our team

public class ChampionshipPoints {

  public static int points(String[] games) {
    int championshipPoints = 0;
    for (String score : games) {
      char[] curScore = score.toCharArray();
      int ourScore = (int) curScore[0];
      int theirScore = (int) curScore[2];
      if (ourScore > theirScore)
        championshipPoints += 3;
      else if (ourScore == theirScore)
        championshipPoints += 1;
    }
    return championshipPoints;
  }

  public static void main(String[] args) {
    System.out.println(points(new String[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" })); // 30
    System.out.println(points(new String[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" })); // 0
  }
}

/*
 * Our football team has finished the championship.
 * 
 * Our team's match results are recorded in a collection of strings. Each match
 * is represented by a string in the format "x:y", where x is our team's score
 * and y is our opponents score.
 * 
 * For example: ["3:1", "2:2", "0:1", ...]
 * 
 * Points are awarded for each match as follows:
 * 
 * if x > y: 3 points (win)
 * if x < y: 0 points (loss)
 * if x = y: 1 point (tie)
 * 
 * We need to write a function that takes this collection and returns the number
 * of points our team (x) got in the championship by the rules given above.
 * 
 * Notes:
 * 
 * our team always plays 10 matches in the championship
 * 0 <= x <= 4
 * 0 <= y <= 4
 * 
 * 
 */