// function to return letter grade of 3 averaged scores

public class GradeBook {

  public static char getGrade(int s1, int s2, int s3) {
    double avgGrade = (s1 + s2 + s3) / 3;
    if (avgGrade >= 90)
      return 'A';
    if (avgGrade >= 80)
      return 'B';
    if (avgGrade >= 70)
      return 'C';
    if (avgGrade >= 60)
      return 'D';
    else
      return 'F';
  }

  public static void main(String[] args) {
    System.out.println(getGrade(95, 90, 93)); // A
    System.out.println(getGrade(70, 70, 100)); // B
    System.out.println(getGrade(44, 55, 52)); // F
  }

}

/*
 * Complete the function so that it finds the average of the three scores passed
 * to it and returns the letter value associated with that grade.
 */
