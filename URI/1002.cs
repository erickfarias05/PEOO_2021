using System;

class Program {
  public static void Main() {
   double r = double.Parse(Console.ReadLine());
   double pi = 3.14159;
   double x = pi * Math.Pow(r, 2);
   Console.WriteLine($"A={x:0.0000}");
  }

  
}