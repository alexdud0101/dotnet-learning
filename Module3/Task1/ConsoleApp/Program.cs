class Program
{
  public static void Main()
  {

    string name = "";
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
    if (name == "Gonsales")
    {
      Console.WriteLine($"Hello Bombino!!!");
    }
    else
    {
      Console.WriteLine($"Hello {name}");
    }
  }
}