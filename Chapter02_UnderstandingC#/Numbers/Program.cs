using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      uint naturalNumber = 23;
      int integerNumber = -23;
      float realNumber = 2.3F;
      double anotherRealNumber = 2.3;

      int decimalNotation = 2_000_000;
      int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
      int hexadecimalNotation = 0x_001E_8480;
      Console.WriteLine($"{decimalNotation == binaryNotation}");
      Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

      Console.WriteLine("----------------------------------------");

      Console.WriteLine("Using doubles");

      double a = 0.1;
      double b = 0.2;

      if (a + b == 0.3)
      {
        Console.WriteLine($"{a} + {b} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{a} + {b} does not equals 0.3");
      }

      Console.WriteLine("Using decimals");

      decimal c = 0.1M;
      decimal d = 0.2M;

      if (c + d == 0.3M)
      {
        Console.WriteLine($"{c} + {d} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{c} + {d} does not equals 0.3");
      }
    }
  }
}
