// return winner of a rock paper scissor game

public class RockPaperScissors {

  private static boolean rpsResult(String playerA, String playerB) {
    if (playerA == "rock" && playerB == "scissors") {
      return true;
    } else if (playerA == "scissors" && playerB == "paper") {
      return true;
    } else if (playerA == "paper" && playerB == "rock") {
      return true;
    } else
      return false;
  }

  public static String rps(String p1, String p2) {
    if (p1 == p2) {
      return "Draw!";
    } else {
      return rpsResult(p1, p2) ? "Player 1 won!" : "Player 2 won!";
    }
  }

  public static void main(String[] args) {
    System.out.println(rps("paper", "paper")); // Draw
    System.out.println(rps("rock", "paper")); // Player 2 wins
    System.out.println(rps("paper", "scissors")); // Player 2 wins
    System.out.println(rps("rock", "scissors")); // Player 1 wins
  }
}

/*
 * Let's play! You have to return which player won! In case of a draw return
 * Draw!.
 * 
 * Examples(Input1, Input2 --> Output):
 */
