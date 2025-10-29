using System;
class Program 
{
   static void Main() 
   {
     Console.Write("Digite um número: ");
     int num = Convert.ToInt32(Console.ReadLine());
     if (num % 2 == 0)
     Console.WriteLine("Par");
     else
     Console.WriteLine("Ímpar");
   }
}

