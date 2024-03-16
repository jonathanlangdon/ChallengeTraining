// return new position based on roll of dice movement

public class TerminalGameMove {

  public static int move(int position, int roll) {
    return position + roll * 2;
  }

  public static void main(String[] args) {
    System.out.println(move(3, 6)); // 15
    System.out.println(move(1, 1)); // 3
  }
}

/*
 * In this game, the hero moves from left to right. The player rolls the dice
 * and moves the number of spaces indicated by the dice two times.
 * 
 * Create a function for the terminal game that takes the current position of
 * the hero and the roll (1-6) and return the new position.
 * Example:
 * 
 * move(3, 6) should equal 15
 */