public class CountTheSheep {
  public static int countSheeps(Boolean[] arrayOfSheeps) {
    int sheepCount = 0;
    for (Boolean sheep : arrayOfSheeps) {
      if (sheep != null && sheep)
        sheepCount += 1;
    }
    return sheepCount;
  }

  public static void main(String[] args) {
    Boolean[] array1 = { true, true, true, false,
        true, true, true, true,
        true, false, true, false,
        true, false, false, true,
        true, true, true, true,
        false, false, true, true };

    System.out.println(countSheeps(array1)); // 17
  }
}