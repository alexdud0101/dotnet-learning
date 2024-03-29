using Lib;
class Program
{
  public static void Main()
  {

    string? name = "";
    while (string.IsNullOrEmpty(name))
    {
      Console.WriteLine("Write your name");
      name = Console.ReadLine();
      if (string.IsNullOrEmpty(name))
      {
        Console.WriteLine("You should type your name");
        name = Console.ReadLine();
      }

    }

    var output = (name == "Gonsales") ? "Hello Bombino!!!" : $"Hello {name}";

    var timeOutput = Time.AddTime(output);
    Console.WriteLine(timeOutput);
  }


}