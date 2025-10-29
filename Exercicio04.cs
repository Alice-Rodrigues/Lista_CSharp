using System;
class Program 
{
   static void Main() 
   {
       Console.Write("Digite o primeiro número: ");
       int a = int.Parse(Console.ReadLine());
     
       Console.Write("Digite o segundo número: ");
       int b = int.Parse(Console.ReadLine());
     
       Console.Write("Digite o terceiro número: ");
       int c = int.Parse(Console.ReadLine());
     
       int maior = Math.Max(a, Math.Max(b, c));
       Console.WriteLine($"O maior número é: {maior}");
    }
}
