using System;
class Program 
{
     static void Main() 
     {
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numeros);
        Console.WriteLine("Ordem crescente: " + string.Join(", ", numeros));
    }
}
