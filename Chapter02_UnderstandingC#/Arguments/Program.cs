using System;
using static System.Console;

namespace Arguments
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length < 3)
      {
        WriteLine("You must specify two colors and cursor size, e.g.");
        WriteLine("dotnet run red yellow 50");
        return;
      }

      ConsoleColor foregroundColor = (ConsoleColor)Enum.Parse(
        enumType: typeof(ConsoleColor),
        value: args[0],
        ignoreCase: true
      );

      ConsoleColor backgroundColor = (ConsoleColor)Enum.Parse(
        enumType: typeof(ConsoleColor),
        value: args[1],
        ignoreCase: true
      );

      int cursorSize = int.Parse(args[2]);

      SetCursorSize(cursorSize);

      PrintArguments(args, foregroundColor, backgroundColor);
    }

    private static void PrintArguments(string[] args, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
    {
      System.Console.ForegroundColor = foregroundColor;
      System.Console.BackgroundColor = backgroundColor;

      WriteLine($"There are {args.Length} arguments");

      foreach (string arg in args)
      {
        WriteLine(arg);
      }
    }

    private static void SetCursorSize(int cursorSize)
    {
      try
      {
        if (System.OperatingSystem.IsWindows())
        {
          WriteLine("The current platform does not support changing the size of the cursor.");
        }
        else
        {
          CursorSize = cursorSize;
        }
      }
      catch (PlatformNotSupportedException)
      {
        WriteLine("The current platform does not support changing the size of the cursor.");
      }
    }
  }
}
