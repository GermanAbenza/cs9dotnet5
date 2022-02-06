using System;
using System.IO;
using System.Xml;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      Object height = 1.88;
      Object name = "Amir";
      Console.WriteLine("${name} is {height} meters tall.");

      // int length1 = name.Length;
      int length2 = ((string)name).Length;
      Console.WriteLine("${name} has {length2} characters");

      var population = 66_000_000;
      var weight = 1.88;
      var price = 4.99M;
      var fruit = "Apples";
      var letter = 'Z';
      var happy = true;

      // good use of var
      var xml1 = new XmlDocument();
      // StreamWriter file2 = File.CreateText(@"C:\something.txt");

      // bad use of var
      // var file1 = File.CreateText(@"C:\something.txt");

      // target-typed new
      XmlDocument xml13 = new();

      Console.WriteLine($"default(int) = {default(int)}");
      Console.WriteLine($"default(bool) = {default(bool)}");
      Console.WriteLine($"default(DateTime) = {default(DateTime)}");
      Console.WriteLine($"default(string) = {default(string)}");
    }
  }
}