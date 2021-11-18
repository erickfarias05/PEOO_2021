using System;

public class Program {
  public static void Main() {
    int v = int.Parse(Console.ReadLine());
    int velo = int.Parse(Console.ReadLine());
    int t = v * velo;
    double c = t / 12.0;
    Console.WriteLine($"{c:0.000}");
  }


}