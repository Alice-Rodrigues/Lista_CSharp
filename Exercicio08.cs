using System;
class Program
{
     static void Main() 
     {
         double soma = 0;
         for (int i = 1; i <= 5; i++) 
         {
             Console.Write($"Digite a nota {i}: ");
             soma += double.Parse(Console.ReadLine());
         }
         Console.WriteLine($"Média da turma: {soma / 5}");
     }
}
