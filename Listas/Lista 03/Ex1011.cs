using System;

public class Program {
  public static void Main() {
    double r = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double x = (4 / 3.0) * pi * Math.Pow(r, 3);
    Console.WriteLine($"VOLUME = {x:0.000}");
  }


}