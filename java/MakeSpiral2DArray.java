// make a spiral programmatically

import java.util.Arrays;

public class MakeSpiral2DArray {
  static int x = 0;
  static int y = 0;

  public static int[][] spiralize(int size) {

    int[][] theSpiral = new int[size][size];

    theSpiral[y][x] = 1;

    boolean canMove = true;

    while (canMove) {
      moveRight(theSpiral);
      moveDown(theSpiral);
      moveLeft(theSpiral);
      moveUp(theSpiral);

      canMove = checkCanMoveDown(theSpiral)
          || checkCanMoveLeft(theSpiral)
          || checkCanMoveRight(theSpiral)
          || checkCanMoveUp(theSpiral);
    }
    x = 0;
    y = 0;
    return theSpiral;
  }

  static void moveRight(int[][] spiral) {
    while (checkCanMoveRight(spiral)) {
      x += 1;
      spiral[y][x] = 1;
    }
  }

  static void moveDown(int[][] spiral) {
    while (checkCanMoveDown(spiral)) {
      y += 1;
      spiral[y][x] = 1;
    }
  }

  static void moveLeft(int[][] spiral) {
    while (checkCanMoveLeft(spiral)) {
      x -= 1;
      spiral[y][x] = 1;
    }
  }

  static void moveUp(int[][] spiral) {
    while (checkCanMoveUp(spiral)) {
      y -= 1;
      spiral[y][x] = 1;
    }
  }

  static boolean checkCanMoveRight(int[][] spiral) {
    if (x + 1 >= spiral.length)
      return false;
    else if ((x + 2 < spiral.length) && (spiral[y][x + 2] == 1))
      return false;
    else if (spiral[y + 1][x + 1] == 1)
      return false;
    else
      return true;
  }

  static boolean checkCanMoveDown(int[][] spiral) {
    if (y + 1 >= spiral.length || spiral[y + 1][x] == 1)
      return false;
    else if (y + 2 < spiral.length && spiral[y + 2][x] == 1)
      return false;
    else
      return true;
  }

  static boolean checkCanMoveLeft(int[][] spiral) {
    if (x - 1 < 0)
      return false;
    else if (x - 2 >= 0 && spiral[y][x - 2] == 1)
      return false;
    else if (spiral[y - 1][x - 1] == 1)
      return false;
    else
      return true;
  }

  static boolean checkCanMoveUp(int[][] spiral) {
    if (y - 1 < 0 || spiral[y - 1][x] == 1)
      return false;
    else if (y - 2 >= 0 && spiral[y - 2][x] == 1)
      return false;
    else
      return true;
  }

  public static void main(String[] args) {
    int size = 8;
    int[][] spiral = spiralize(size);

    for (int i = 0; i < size; i++) {
      System.out.println(Arrays.toString(spiral[i]));
    }
  }
}
