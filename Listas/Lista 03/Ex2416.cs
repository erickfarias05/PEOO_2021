using System;

public class Program {
  public static void Main() {
    string y = Console.ReadLine();
    string[] x = y.Split(' ');
    int C = int.Parse(x[0]);
    int N = int.Parse(x[1]);
    int result = C % N;
    Console.WriteLine($"{result}");

  }


}