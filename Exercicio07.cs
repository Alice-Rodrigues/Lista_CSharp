using System;
class Program 
{
    static void Main() 
    {
         Console.Write("Digite a temperatura em Celsius: ");
         double c = Convert.ToDouble(Console.ReadLine());
         double f = c * 1.8 + 32;
         Console.WriteLine($"Temperatura em Fahrenheit: {f}");
    }
}
