using System;

// #nullable enable

namespace NullHandling
{
  class Program
  {
    static void Main(string[] args)
    {
      int thisCannotBeNull = 4;
      // thisCannotBeNull = null;

      int? thisCouldBeNull = null;

      Console.WriteLine(thisCouldBeNull);
      Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

      thisCouldBeNull = 7;
      Console.WriteLine(thisCouldBeNull);
      Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

      Address address = new();
      address.Building = null;
      address.Street = null;
      address.City = "London";
      address.Region = null;

      string authorName = null;
      // Unhandled exception NullReferenceException
      // int x = authorName.Length;
      int? y = authorName?.Length;
      var result = authorName?.Length ?? 3;
      Console.WriteLine(result);

      Console.WriteLine("-----------------------------");
      Console.WriteLine("Type your first name and press ENTER: ");
      string firstName = Console.ReadLine();

      Console.WriteLine("Type your age and press ENTER: ");
      string age = Console.ReadLine();

      Console.WriteLine($"Hello {firstName}, your look god for {age}");

      Console.WriteLine("-----------------------");
      Console.Write("Press any key combination: ");
      ConsoleKeyInfo key = Console.ReadKey();
      Console.WriteLine();
      Console.WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
      
    }
  }

  class Address
  {
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public String Region = string.Empty;
  }
}
