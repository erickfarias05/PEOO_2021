using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int y = int.Parse(Console.ReadLine());
    int media = ((x * 2) + (y * 3)) / 5;
    Console.WriteLine($"Média Parcial = {media}");
  }

}
