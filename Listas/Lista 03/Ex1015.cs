using System;

public class Program {
  public static void Main() {
    string y = Console.ReadLine();
    string[] x = y.Split(' ');
    string c = Console.ReadLine();
    string[] v = c.Split(' ');
    double x1 = double.Parse(x[0]);
    double y1 = double.Parse(x[1]);
    double x2 = double.Parse(v[0]);
    double y2 = double.Parse(v[1]);
    double re = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
    Console.WriteLine($"{re:0.0000}");
  }

  
}           