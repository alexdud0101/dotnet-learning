namespace Lib;

public class Time
{
  public static string AddTime(string input)
  {
    var currentTime = DateTime.Now.TimeOfDay.ToString(@"hh\:mm");
    return currentTime + " " + input;
  }
}
