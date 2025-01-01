// fix HashMap

import java.util.HashMap;

public class FixHashMap {

    public static HashMap <String, String> getStatus(boolean isBusy) {
        HashMap<String, String> status = new HashMap<>();
        status.put("status", isBusy ? "busy" : "available");
        return status;
    }

    public static void main(String[] args) {
      System.out.println(getStatus(true).get("status")); // busy
      System.out.println(getStatus(false).get("status")); // available
    }
  
}
