// format seconds to readable time - years, days, hours, minutes, seconds

import java.util.Arrays;

public class TimeFormatter {

  public static String formatDuration(int seconds) {
    if (seconds == 0)
      return "now";
    int year = seconds / 31536000;
    int day = (seconds % 31536000) / 86400;
    int hour = (seconds % 86400) / 3600;
    int min = (seconds % 3600) / 60;
    int sec = seconds % 60;
    int[] times = { year, day, hour, min, sec };
    String[] label = { " year", " day", " hour", " minute", " second" };
    long validTimesCount = Arrays.stream(times).filter(x -> x > 0).count();
    int usedTimesCount = 0;
    String result = "";

    for (int i = 0; i < times.length; i++) {
      if (times[i] > 0) {
        result += times[i] + label[i] + (times[i] > 1 ? "s" : "");
        usedTimesCount += 1;
        if (validTimesCount - usedTimesCount > 1)
          result += ", ";
        else if (validTimesCount - usedTimesCount == 1)
          result += " and ";
      }
    }

    return result;
  }

  public static void main(String[] args) {
    System.out.println(formatDuration(1)); // "1 second",
    System.out.println(formatDuration(62)); // "1 minute and 2 seconds"
    System.out.println(formatDuration(120)); // "2 minutes"
    System.out.println(formatDuration(3600)); // "1 hour"
    System.out.println(formatDuration(3662)); // "1 hour, 1 minute and 2 seconds"
    System.out.println(formatDuration(0)); // "now"
    System.out.println(formatDuration(87250)); // "1 day, 14 minutes and 10 seconds"
    System.out.println(formatDuration(8725350)); // "100 days, 23 hours, 42 minutes and 30 seconds"
    System.out.println(formatDuration(872535320)); // "27 years, 243 days, 18 hours, 55 minutes and 20 seconds"

  }

}