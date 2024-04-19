// change whether an alarm goes off depending on vacation/employed

public class SetAlarmEmployedVacation
{
	public static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(SetAlarm(true, true)); // false
		System.Console.WriteLine(SetAlarm(true, false)); // true
		System.Console.WriteLine(SetAlarm(false, true)); // false
		System.Console.WriteLine(SetAlarm(false, true)); // false
	}
}