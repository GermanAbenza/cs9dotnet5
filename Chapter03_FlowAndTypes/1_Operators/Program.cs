using System;

namespace Operators
{
  class Program
  {
    static void Main(string[] args)
    {
      /* UNARY OPERATORS */
      int a = 3;
      int b = a++; // the ++ operator executes after the assignment
      Console.WriteLine($"a is {a}, and b is {b}");

      int c = 3;
      int d = ++c; // the ++ operator executes before the assignment
      Console.WriteLine($"c is {c}, and d is {d}");

      /* BINARY ARITHMETIC OPERATORS */
      int e = 11;
      int f = 3;
      Console.WriteLine($"e is {e}, f is {f}");
      Console.WriteLine($"e + f = {e + f}");
      Console.WriteLine($"e - f = {e - f}");
      Console.WriteLine($"e * f = {e * f}");
      Console.WriteLine($"e / f = {e / f}");
      Console.WriteLine($"e % f = {e % f}");

      double g = 11.0;
      Console.WriteLine($"g is {g:N1}, f is {f}");
      Console.WriteLine($"g / f = {g / f}");
    }
  }
}
