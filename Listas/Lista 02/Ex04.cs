using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a base e altura do retângulo:");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double area = x * y;
    double perimetro = (x * 2) + (y * 2);
    double diagonal = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
     Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");

  }

}