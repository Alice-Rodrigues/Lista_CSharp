using System;
class Program 
{
   static void Main() 
   {
     Console.Write("Digite uma palavra: ");
     string palavra = Console.ReadLine().ToLower();
     int contador = 0;
     foreach (char c in palavra)
     if ("aeiou".Contains(c))
     contador++;
     Console.WriteLine($"Quantidade de vogais: {contador}");
 }
}
