using System;
using System.Linq;
class Vetores 
{
    static void Main() 
    {
        double[] numeros = new double[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Maior: {numeros.Max()} | Menor: {numeros.Min()} | Média: {numeros.Average()}");
    }
}
