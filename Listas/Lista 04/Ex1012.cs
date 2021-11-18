using System;

public class Program {
  public static void Main() {
    string y = Console.ReadLine();
    string[] x = y.Split(' ');
    double a = double.Parse(x[0]);
    double b = double.Parse(x[1]);  
    double c = double.Parse(x[2]);
    double tri = (a * c) / 2;
    double cir = 3.14159 * Math.Pow(c, 2);
    double trap = (a + b) * c / 2;
    double qua = b * b;
    double ret = a * b;
    Console.WriteLine($"TRIANGULO: {tri:0.000}");
    Console.WriteLine($"CIRCULO: {cir:0.000}");
    Console.WriteLine($"TRAPEZIO: {trap:0.000}");
    Console.WriteLine($"QUADRADO: {qua:0.000}");
    Console.WriteLine($"RETANGULO: {ret:0.000}");
  }


}