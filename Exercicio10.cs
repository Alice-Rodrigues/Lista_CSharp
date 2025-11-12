using System;
class Program 
{
    static void Main() 
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        bool primo = true;
        for (int i = 2; i < num; i++) 
        {
            if (num % i == 0) 
            {
                primo = false;
                break;
            }
        }
        Console.WriteLine(primo ? "É primo" : "Não é primo");
    }
}
