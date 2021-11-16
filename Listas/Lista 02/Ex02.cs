using System;  

public class Program { 
  public static void Main() { 
    Console.WriteLine("Digite seu nome completo:"); 
    string s = Console.ReadLine(); 
    string[] a = s.Split(' ');
    string x = a[0];
    Console.WriteLine($"Bem vindo ao C#, {x}"); 
  } 
}